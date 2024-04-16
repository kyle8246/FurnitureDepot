using FurnitureDepot.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FurnitureDepot.DAL
{
    /// <summary>
    /// RentalDAL Class
    /// </summary>
    public class RentalDAL
    {
        /// <summary>
        /// Gets the rental transactions by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public List<RentalTransaction> GetRentalTransactionsByMemberID(int memberID)
        {
            List<RentalTransaction> transactions = new List<RentalTransaction>();

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"SELECT rt.RentalTransactionID, rt.MemberID, rt.EmployeeID, rt.RentalDate, rt.DueDate, rt.TotalCost,
                                       e.FirstName + ' ' + e.LastName as EmployeeName,
                                       c.FirstName + ' ' + c.LastName as CustomerName
                                FROM RentalTransaction rt
                                JOIN Employee e ON rt.EmployeeID = e.EmployeeID
                                JOIN Member c ON rt.MemberID = c.MemberID
                                WHERE rt.MemberID = @MemberID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var transaction = new RentalTransaction
                            {
                                RentalTransactionID = reader.GetInt32(0),
                                MemberID = reader.GetInt32(1),
                                EmployeeID = reader.GetInt32(2),
                                RentalDate = reader.GetDateTime(3),
                                DueDate = reader.GetDateTime(4),
                                TotalCost = reader.GetDecimal(5),
                                EmployeeName = reader.GetString(6),
                                CustomerName = reader.GetString(7)
                            };

                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

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
                string query = @"SELECT ri.RentalItemID, ri.RentalTransactionID, ri.FurnitureID, f.Name, f.Description, 
                                f.CategoryName, f.StyleName, ri.DailyRate, ri.Quantity, ri.QuantityReturned
                                FROM RentalItem ri
                                JOIN Furniture f ON ri.FurnitureID = f.FurnitureID
                                WHERE ri.RentalTransactionID = @RentalTransactionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@RentalTransactionID", SqlDbType.Int).Value = rentalTransactionID;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rentalItems.Add(new RentalItem
                            {
                                RentalItemID = reader.GetInt32(0),
                                RentalTransactionID = reader.GetInt32(1),
                                FurnitureID = reader.GetInt32(2),
                                FurnitureName = reader.GetString(3),
                                Description = reader.GetString(4),
                                CategoryName = reader.GetString(5),
                                StyleName = reader.GetString(6),
                                DailyRate = reader.GetDecimal(7),
                                Quantity = reader.GetInt32(8),
                                QuantityReturned = reader.IsDBNull(9) ? 0 : reader.GetInt32(9)
                            });
                        }
                    }
                }
            }

            return rentalItems;
        }

        /// <summary>
        /// Gets the rental transaction by identifier.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns></returns>
        public RentalTransaction GetRentalTransactionById(int transactionId)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"SELECT RentalTransactionID, MemberID, EmployeeID, RentalDate, DueDate, TotalCost
                         FROM RentalTransaction
                         WHERE RentalTransactionID = @TransactionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TransactionID", transactionId);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RentalTransaction
                            {
                                RentalTransactionID = reader.GetInt32(reader.GetOrdinal("RentalTransactionID")),
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                RentalDate = reader.GetDateTime(reader.GetOrdinal("RentalDate")),
                                DueDate = reader.GetDateTime(reader.GetOrdinal("DueDate")),
                                TotalCost = reader.GetDecimal(reader.GetOrdinal("TotalCost")),
                            };
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Inserts the rental transaction.
        /// </summary>
        /// <param name="rentalTransaction">The rental transaction.</param>
        /// <param name="sqlTransaction">The SQL transaction.</param>
        /// <returns></returns>
        public int InsertRentalTransaction(RentalTransaction rentalTransaction, SqlTransaction sqlTransaction)
        {
            string insertQuery = @"
        INSERT INTO RentalTransaction (MemberID, EmployeeID, RentalDate, DueDate, TotalCost)
        OUTPUT INSERTED.RentalTransactionID
        VALUES (@MemberID, @EmployeeID, @RentalDate, @DueDate, @TotalCost);";

            using (SqlCommand command = new SqlCommand(insertQuery, sqlTransaction.Connection, sqlTransaction))
            {
                command.Parameters.AddWithValue("@MemberID", rentalTransaction.MemberID);
                command.Parameters.AddWithValue("@EmployeeID", rentalTransaction.EmployeeID);
                command.Parameters.AddWithValue("@RentalDate", rentalTransaction.RentalDate);
                command.Parameters.AddWithValue("@DueDate", rentalTransaction.DueDate);
                command.Parameters.AddWithValue("@TotalCost", rentalTransaction.TotalCost);

                int insertedId = (int)command.ExecuteScalar();
                return insertedId;
            }
        }

        /// <summary>
        /// Inserts the rental items.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="transaction">The transaction.</param>
        public void InsertRentalItems(List<RentalItem> items, SqlTransaction transaction)
        {
            foreach (var item in items)
            {
                string insertItemQuery = @"
            INSERT INTO RentalItem (RentalTransactionID, FurnitureID, Quantity, DailyRate)
            VALUES (@RentalTransactionID, @FurnitureID, @Quantity, @DailyRate);";

                using (SqlCommand command = new SqlCommand(insertItemQuery, transaction.Connection, transaction))
                {
                    command.Parameters.AddWithValue("@RentalTransactionID", item.RentalTransactionID);
                    command.Parameters.AddWithValue("@FurnitureID", item.FurnitureID);
                    command.Parameters.AddWithValue("@Quantity", item.Quantity);
                    command.Parameters.AddWithValue("@DailyRate", item.DailyRate);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
