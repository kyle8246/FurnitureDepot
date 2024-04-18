﻿using FurnitureDepot.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FurnitureDepot.DAL
{
    /// <summary>
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
        public bool CompleteReturnProcess(int employeeID, int memberID, List<RentalItem> itemsToReturn)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int returnTransactionID = CreateReturnTransaction(employeeID, memberID, transaction);

                        foreach (var item in itemsToReturn)
                        {
                            if (!UpdateReturnedQuantity(item.RentalItemID, item.QuantityReturned, transaction))
                            {
                                throw new Exception("Failed to update returned quantity.");
                            }

                            ReturnedItem returnedItem = new ReturnedItem
                            {
                                ReturnTransactionID = returnTransactionID,
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
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return false;
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

    }
}
