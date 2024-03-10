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

        /// <summary>
        /// Gets the customer by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public Customer GetCustomerByMemberID(int memberID)
        {
            Customer customer = null;

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"
                    SELECT MemberID, LastName, FirstName, Sex, DateOfBirth, 
                           StreetAddress, City, State, ZipCode, ContactPhone
                    FROM Member
                    WHERE MemberID = @MemberID";

                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer = new Customer
                            {
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                Sex = reader.GetString(reader.GetOrdinal("Sex")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                StreetAddress = reader.GetString(reader.GetOrdinal("StreetAddress")),
                                City = reader.GetString(reader.GetOrdinal("City")),
                                State = reader.GetString(reader.GetOrdinal("State")),
                                ZipCode = reader.GetString(reader.GetOrdinal("ZipCode")),
                                ContactPhone = reader.GetString(reader.GetOrdinal("ContactPhone"))
                            };
                        }
                    }
                }
            }
            return customer;
        }

    }
}
