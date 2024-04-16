using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FurnitureDepot.Model;

namespace FurnitureDepot.DAL
{
    /// <summary>
    /// Furniture DAL Class
    /// </summary>
    public class FurnitureDAL
    {
        /// <summary>
        /// Searches the furniture.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <param name="category">The category.</param>
        /// <param name="style">The style.</param>
        /// <returns></returns>
        public List<Furniture> SearchFurniture(string furnitureID, string category, string style)
        {
            List<Furniture> furnitureItems = new List<Furniture>();

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"
                    SELECT FurnitureID, Name, Description, CategoryName, StyleName, DailyRentalRate, Quantity, InStockNumber
                    FROM Furniture
                     WHERE (@FurnitureID IS NULL OR FurnitureID = @FurnitureID) AND
                            (@CategoryName IS NULL OR CategoryName = @CategoryName) AND
                            (@StyleName IS NULL OR StyleName = @StyleName)";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FurnitureID", string.IsNullOrEmpty(furnitureID) ? (object)DBNull.Value : Convert.ToInt32(furnitureID));
                    command.Parameters.AddWithValue("@CategoryName", string.IsNullOrEmpty(category) ? (object)DBNull.Value : category);
                    command.Parameters.AddWithValue("@StyleName", string.IsNullOrEmpty(style) ? (object)DBNull.Value : style);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new Furniture
                            {
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                                CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                StyleName = reader.GetString(reader.GetOrdinal("StyleName")),
                                DailyRentalRate = reader.IsDBNull(reader.GetOrdinal("DailyRentalRate")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("DailyRentalRate")),
                                Quantity = reader.IsDBNull(reader.GetOrdinal("Quantity")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Quantity")),
                                InStockNumber = reader.IsDBNull(reader.GetOrdinal("InStockNumber")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("InStockNumber"))
                            };
                            furnitureItems.Add(item);
                        }
                    }
                }
            }
            return furnitureItems;
        }

        /// <summary>
        /// Gets all furniture items.
        /// </summary>
        /// <returns></returns>
        public List<Furniture> GetAllFurnitureItems()
        {
            List<Furniture> furnitureItems = new List<Furniture>();

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = "SELECT FurnitureID, Name, Description, CategoryName, StyleName, DailyRentalRate, Quantity, InStockNumber" +
                    "           FROM Furniture";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture item = new Furniture
                            {
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                                CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                StyleName = reader.GetString(reader.GetOrdinal("StyleName")),
                                DailyRentalRate = reader.IsDBNull(reader.GetOrdinal("DailyRentalRate")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("DailyRentalRate")),
                                Quantity = reader.IsDBNull(reader.GetOrdinal("Quantity")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Quantity")),
                                InStockNumber = reader.IsDBNull(reader.GetOrdinal("InStockNumber")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("InStockNumber"))
                            };
                            furnitureItems.Add(item);
                        }
                    }
                }
            }
            return furnitureItems;
        }

        /// <summary>
        /// Checks the in stock quantity of the furniture item.
        /// </summary>
        /// <param name="furnitureID">The furniture item identifier.</param>
        /// <param name="requiredQuantity">The required quantity requested.</param>
        /// <returns></returns>
        public bool CheckInStock(int furnitureID, int requiredQuantity)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                connection.Open();
                string query = "SELECT InStockNumber FROM Furniture WHERE FurnitureID = @FurnitureID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FurnitureID", furnitureID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int inStock = reader.GetInt32(reader.GetOrdinal("InStockNumber"));
                            if (inStock >= requiredQuantity)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Updates the in stock number.
        /// </summary>
        /// <param name="furnitureId">The furniture identifier.</param>
        /// <param name="quantityToSubtract">The quantity to subtract.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns></returns>
        public bool UpdateInStockNumber(int furnitureId, int quantityToSubtract, SqlTransaction transaction)
        {
            string query = @"
        UPDATE Furniture
        SET InStockNumber = InStockNumber - @QuantityToSubtract
        WHERE FurnitureID = @FurnitureID AND InStockNumber >= @QuantityToSubtract";

            SqlCommand command = new SqlCommand(query, transaction.Connection, transaction);
            command.Parameters.AddWithValue("@FurnitureID", furnitureId);
            command.Parameters.AddWithValue("@QuantityToSubtract", quantityToSubtract);

            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected > 0;
        }

        public List<string> GetFurnitureCategories()
        {
            List<string> categories = new List<string>();
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = "SELECT DISTINCT CategoryName FROM Furniture ORDER BY CategoryName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(reader["CategoryName"].ToString());
                        }
                    }
                }
            }
            return categories;
        }

        public List<string> GetFurnitureStyles()
        {
            List<string> styles = new List<string>();
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = "SELECT DISTINCT StyleName FROM Furniture ORDER BY StyleName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            styles.Add(reader["StyleName"].ToString());
                        }
                    }
                }
            }
            return styles;
        }



    }
}
