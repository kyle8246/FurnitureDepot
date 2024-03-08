using FurnitureDepot.Model;
using System.Data.SqlClient;
using System.Data;

namespace FurnitureDepot.DAL
{
    internal class CustomerDAL
    {
        /// <summary>
        /// Adds a new customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns>Boolean indicating success or failure.</returns>
        public bool AddCustomer(Customer customer)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO Member (LastName, FirstName, Sex, DateOfBirth, 
                                        StreetAddress, City, State, ZipCode, ContactPhone)
                    VALUES (@LastName, @FirstName, @Sex, @DateOfBirth, 
                            @StreetAddress, @City, @State, @ZipCode, @ContactPhone)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar) { Value = customer.LastName });

                connection.Open();

                int result = command.ExecuteNonQuery();

                return result == 1;
            }
        }
    }
}
