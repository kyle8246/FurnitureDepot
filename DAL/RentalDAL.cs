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
                string query = @"SELECT rt.RentalTransactionID, rt.MemberID, rt.EmployeeID, rt.RentalDate, rt.DueDate, rt.TotalCost
                                 FROM RentalTransaction rt
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

    }
}
