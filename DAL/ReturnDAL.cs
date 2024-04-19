using FurnitureDepot.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FurnitureDepot.DAL
{
    /// <summary>
    /// ReturnDAL Class
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
                    SELECT ReturnedItemID, ReturnTransactionID, RentalItemID, QuantityReturned
                    FROM ReturnedItem
                    WHERE ReturnTransactionID = @ReturnTransactionID";

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
                                QuantityReturned = reader.IsDBNull(reader.GetOrdinal("QuantityReturned")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("QuantityReturned"))
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
                string query = @"SELECT * FROM ReturnTransaction WHERE MemberID = @MemberID";

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
                            };

                            returnTransactions.Add(returnTransaction);
                        }
                    }
                }
            }

            return returnTransactions;
        }
    }
}
