using FurnitureDepot.Model;
using FurnitureDepot.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FurnitureDepot.DAL

{    /// <summary>
     /// DAL for returns
     /// </summary>    
    public class ReturnDAL
    {
        /// <summary>
        /// Gets the rental items by transaction identifier.
        /// </summary>
        /// <param name="rentalTransactionID">The rental transaction identifier.</param>
        /// <returns></returns>
        public List<RentalItem> GetRentalItemsByTransactionId(int rentalTransactionID)
        {
            List<RentalItem> rentalItems = new List<RentalItem>();

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"SELECT ri.RentalItemID, ri.RentalTransactionID, ri.FurnitureID, f.Name, 
                                ri.Quantity, ri.DailyRate, ri.QuantityReturned
                                FROM RentalItem ri
                                INNER JOIN Furniture f ON ri.FurnitureID = f.FurnitureID
                                WHERE ri.RentalTransactionID = @RentalTransactionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RentalTransactionID", rentalTransactionID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalItem rentalItem = new RentalItem
                            {
                                RentalItemID = reader.GetInt32(reader.GetOrdinal("RentalItemID")),
                                RentalTransactionID = reader.GetInt32(reader.GetOrdinal("RentalTransactionID")),
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                FurnitureName = reader.GetString(reader.GetOrdinal("Name")),
                                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                                DailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate")),
                                QuantityReturned = reader.IsDBNull(reader.GetOrdinal("QuantityReturned")) ? 0 : reader.GetInt32(reader.GetOrdinal("QuantityReturned"))
                            };

                            rentalItems.Add(rentalItem);
                        }
                    }
                }
            }

            return rentalItems;
        }

        /// <summary>
        /// Updates the returned quantity.
        /// </summary>
        /// <param name="rentalItemID">The rental item identifier.</param>
        /// <param name="quantityReturned">The quantity returned.</param>
        private bool UpdateReturnedQuantity(int rentalItemID, int quantityReturned, SqlTransaction transaction)
        {
            if (!IsReturnQuantityValid(rentalItemID, quantityReturned, transaction))
            {
                throw new InvalidOperationException("The quantity returned exceeds initial rental quantity.");
            }

            string query = @"
                    UPDATE RentalItem 
                    SET QuantityReturned = QuantityReturned + @QuantityReturned 
                    WHERE RentalItemID = @RentalItemID";

            using (SqlCommand command = new SqlCommand(query, transaction.Connection, transaction))
            {
                command.Parameters.AddWithValue("@RentalItemID", rentalItemID);
                command.Parameters.AddWithValue("@QuantityReturned", quantityReturned);
                return command.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Checks if the quantity being returned does not exceed the quantity rented.
        /// </summary>
        /// <param name="rentalItemID">The rental item identifier.</param>
        /// <param name="quantityReturned">The quantity returned.</param>
        /// <param name="transaction">The SQL transaction.</param>
        /// <returns>True if the quantity is valid, false otherwise.</returns>
        private bool IsReturnQuantityValid(int rentalItemID, int quantityReturned, SqlTransaction transaction)
        {
            string query = @"SELECT Quantity, QuantityReturned FROM RentalItem 
                        WHERE RentalItemID = @RentalItemID";
            using (SqlCommand command = new SqlCommand(query, transaction.Connection, transaction))
            {
                command.Parameters.AddWithValue("@RentalItemID", rentalItemID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int currentQuantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                        int currentReturned = reader.GetInt32(reader.GetOrdinal("QuantityReturned"));

                        return (currentReturned + quantityReturned <= currentQuantity);
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Updates the furniture stock.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <param name="quantityReturned">The quantity returned.</param>
        private bool UpdateFurnitureStock(int furnitureID, int quantityReturned, SqlTransaction transaction)
        {
            string query = @"
                    UPDATE Furniture 
                    SET InStockNumber = InStockNumber + @QuantityReturned 
                    WHERE FurnitureID = @FurnitureID";

            using (SqlCommand command = new SqlCommand(query, transaction.Connection, transaction))
            {
                command.Parameters.AddWithValue("@FurnitureID", furnitureID);
                command.Parameters.AddWithValue("@QuantityReturned", quantityReturned);
                return command.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Inserts the returned item.
        /// </summary>
        /// <param name="returnedItem">The returned item.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns></returns>
        private bool InsertReturnedItem(ReturnedItem returnedItem, SqlTransaction transaction)
        {
            string query = @"
            INSERT INTO ReturnedItem (ReturnTransactionID, RentalItemID, QuantityReturned)
            VALUES (@ReturnTransactionID, @RentalItemID, @QuantityReturned);";

            using (SqlCommand command = new SqlCommand(query, transaction.Connection, transaction))
            {
                command.Parameters.AddWithValue("@ReturnTransactionID", returnedItem.ReturnTransactionID);
                command.Parameters.AddWithValue("@RentalItemID", returnedItem.RentalItemID);
                command.Parameters.AddWithValue("@QuantityReturned", returnedItem.QuantityReturned);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        /// <summary>
        /// Completes the return process.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="itemsToReturn">The items to return.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">
        /// Failed to update returned quantity.
        /// or
        /// Failed to insert returned item record.
        /// or
        /// Failed to update furniture stock.
        /// </exception>
        public ReturnProcessResult CompleteReturnProcess(int employeeID, int memberID, List<RentalItem> itemsToReturn)
        {
            var result = new ReturnProcessResult();

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        result.ReturnTransactionID = CreateReturnTransaction(employeeID, memberID, transaction);

                        foreach (var item in itemsToReturn)
                        {
                            if (!UpdateReturnedQuantity(item.RentalItemID, item.QuantityReturned, transaction))
                            {
                                throw new Exception("Failed to update returned quantity.");
                            }

                            ReturnedItem returnedItem = new ReturnedItem
                            {
                                ReturnTransactionID = result.ReturnTransactionID,
                                RentalItemID = item.RentalItemID,
                                QuantityReturned = item.QuantityReturned
                            };

                            if (!InsertReturnedItem(returnedItem, transaction))
                            {
                                throw new Exception("Failed to insert returned item record.");
                            }

                            if (!UpdateFurnitureStock(item.FurnitureID, item.QuantityReturned, transaction))
                            {
                                throw new Exception("Failed to update furniture stock.");
                            }
                        }

                        transaction.Commit();
                        result.IsSuccessful = true;
                        return result;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        result.IsSuccessful = false;
                        result.ErrorMessage = ex.Message;
                        return result;
                    }
                }
            }
        }

        /// <summary>
        /// Creates the return transaction.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns></returns>
        public int CreateReturnTransaction(int employeeID, int memberID, SqlTransaction transaction)
        {
            string query = @"
                    INSERT INTO ReturnTransaction (EmployeeID, MemberID, ReturnDate) 
                    OUTPUT INSERTED.ReturnTransactionID 
                    VALUES (@EmployeeID, @MemberID, GETDATE());";

            using (SqlCommand command = new SqlCommand(query, transaction.Connection, transaction))
            {
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@MemberID", memberID);

                int returnTransactionID = (int)command.ExecuteScalar();
                return returnTransactionID;
            }
        }

        /// <summary>
        /// Gets the rental item for return by rental item identifier.
        /// </summary>
        /// <param name="rentalItemID">The rental item identifier.</param>
        /// <returns></returns>
        public RentalItem GetRentalItemForReturnByRentalItemID(int rentalItemID)
        {
            RentalItem rentalItem = null;

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"SELECT RentalItemID, RentalTransactionID, FurnitureID, Quantity, DailyRate, QuantityReturned
                            FROM RentalItem
                            WHERE RentalItemID = @RentalItemID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RentalItemID", rentalItemID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rentalItem = new RentalItem
                            {
                                RentalItemID = reader.GetInt32(reader.GetOrdinal("RentalItemID")),
                                RentalTransactionID = reader.GetInt32(reader.GetOrdinal("RentalTransactionID")),
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                                DailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate")),
                                QuantityReturned = reader.IsDBNull(reader.GetOrdinal("QuantityReturned")) ? 0 : reader.GetInt32(reader.GetOrdinal("QuantityReturned"))
                            };
                        }
                    }
                }
            }

            return rentalItem;
        }

        /// <summary>
        /// Determines whether [is rental transaction complete] [the specified rental transaction identifier].
        /// </summary>
        /// <param name="rentalTransactionID">The rental transaction identifier.</param>
        /// <returns>
        ///   <c>true</c> if [is rental transaction complete] [the specified rental transaction identifier]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsRentalTransactionComplete(int rentalTransactionID)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"
            SELECT SUM(Quantity) as TotalQuantity, SUM(QuantityReturned) as TotalQuantityReturned
            FROM RentalItem
            WHERE RentalTransactionID = @RentalTransactionID
            GROUP BY RentalTransactionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RentalTransactionID", rentalTransactionID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int totalQuantity = reader.GetInt32(reader.GetOrdinal("TotalQuantity"));
                            int totalQuantityReturned = reader.GetInt32(reader.GetOrdinal("TotalQuantityReturned"));
                            return totalQuantity == totalQuantityReturned;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Gets the returned items by transaction identifier.
        /// </summary>
        /// <param name="returnTransactionID">The return transaction identifier.</param>
        /// <returns></returns>
        public List<ReturnedItem> GetReturnedItemsByTransactionId(int returnTransactionID)
        {
            List<ReturnedItem> returnedItems = new List<ReturnedItem>();

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"
            SELECT ri.ReturnedItemID, ri.ReturnTransactionID, ri.RentalItemID, ri.QuantityReturned,
                   f.Name AS FurnitureName, f.Description, f.CategoryName, f.StyleName, 
                   f.DailyRentalRate AS DailyRate, r.Quantity
            FROM ReturnedItem ri
            INNER JOIN RentalItem r ON ri.RentalItemID = r.RentalItemID
            INNER JOIN Furniture f ON r.FurnitureID = f.FurnitureID
            WHERE ri.ReturnTransactionID = @ReturnTransactionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReturnTransactionID", returnTransactionID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnedItem returnedItem = new ReturnedItem
                            {
                                ReturnedItemID = reader.GetInt32(reader.GetOrdinal("ReturnedItemID")),
                                ReturnTransactionID = reader.IsDBNull(reader.GetOrdinal("ReturnTransactionID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("ReturnTransactionID")),
                                RentalItemID = reader.IsDBNull(reader.GetOrdinal("RentalItemID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("RentalItemID")),
                                QuantityReturned = reader.IsDBNull(reader.GetOrdinal("QuantityReturned")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("QuantityReturned")),
                                FurnitureName = reader.GetString(reader.GetOrdinal("FurnitureName")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                StyleName = reader.GetString(reader.GetOrdinal("StyleName")),
                                DailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate")),
                                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"))
                            };

                            returnedItems.Add(returnedItem);
                        }
                    }
                }
            }

            return returnedItems;
        }

        /// <summary>
        /// Gets the return transactions by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public List<ReturnTransaction> GetReturnTransactionsByMemberID(int memberID)
        {
            List<ReturnTransaction> returnTransactions = new List<ReturnTransaction>();

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"
        SELECT rt.ReturnTransactionID, rt.EmployeeID, rt.MemberID, rt.ReturnDate,
               e.FirstName + ' ' + e.LastName AS EmployeeName,
               m.FirstName + ' ' + m.LastName AS CustomerName,
               rt2.RentalDate, rt2.DueDate
        FROM ReturnTransaction rt
        INNER JOIN Employee e ON rt.EmployeeID = e.EmployeeID
        INNER JOIN Member m ON rt.MemberID = m.MemberID
        LEFT JOIN RentalTransaction rt2 ON rt2.MemberID = rt.MemberID
        WHERE rt.MemberID = @MemberID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnTransaction returnTransaction = new ReturnTransaction
                            {
                                ReturnTransactionID = reader.GetInt32(reader.GetOrdinal("ReturnTransactionID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                ReturnDate = reader.IsDBNull(reader.GetOrdinal("ReturnDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("ReturnDate")),
                                EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                CustomerName = reader.GetString(reader.GetOrdinal("CustomerName")),
                                RentalDate = reader.GetDateTime(reader.GetOrdinal("RentalDate")),
                                DueDate = reader.GetDateTime(reader.GetOrdinal("DueDate"))
                            };

                            returnTransactions.Add(returnTransaction);
                        }
                    }
                }
            }

            return returnTransactions;
        }

        /// <summary>
        /// Gets the return transaction by identifier.
        /// </summary>
        /// <param name="returnTransactionID">The return transaction identifier.</param>
        /// <returns></returns>
        public ReturnTransaction GetReturnTransactionById(int returnTransactionID)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"SELECT ReturnTransactionID, EmployeeID, MemberID, ReturnDate
                         FROM ReturnTransaction
                         WHERE ReturnTransactionID = @TransactionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TransactionID", returnTransactionID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ReturnTransaction
                            {
                                ReturnTransactionID = reader.GetInt32(reader.GetOrdinal("ReturnTransactionID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                ReturnDate = reader.GetDateTime(reader.GetOrdinal("ReturnDate"))
                            };
                        }
                    }
                }
            }
            return null;
        }

    }
}
