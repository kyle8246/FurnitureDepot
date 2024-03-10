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
                command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar) { Value = customer.FirstName });
                command.Parameters.Add(new SqlParameter("@Sex", SqlDbType.NVarChar) { Value = customer.Sex });
                command.Parameters.Add(new SqlParameter("@DateOfBirth", SqlDbType.Date) { Value = customer.DateOfBirth });
                command.Parameters.Add(new SqlParameter("@StreetAddress", SqlDbType.NVarChar) { Value = customer.StreetAddress });
                command.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar) { Value = customer.City });
                command.Parameters.Add(new SqlParameter("@State", SqlDbType.NVarChar) { Value = customer.State });
                command.Parameters.Add(new SqlParameter("@ZipCode", SqlDbType.NVarChar) { Value = customer.ZipCode });
                command.Parameters.Add(new SqlParameter("@ContactPhone", SqlDbType.NVarChar) { Value = customer.ContactPhone });

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result == 1;
            }
        }
    }
}
