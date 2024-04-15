using FurnitureDepot.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FurnitureDepot.DAL
{
    public class ReturnDAL
    {
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

    }
}
