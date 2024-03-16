using FurnitureDepot.Model;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;

namespace FurnitureDepot.DAL
{
    /// <summary>
    /// DAL for Customer 
    /// </summary>
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

        /// <summary>
        /// Searches the customers.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <param name="contactPhone">The contact phone.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
        public List<Customer> SearchCustomers(string memberId, string contactPhone, string lastName, string firstName)
        {
            var customers = new List<Customer>();

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                connection.Open();

                var query = @"SELECT MemberID, LastName, FirstName, Sex, DateOfBirth, 
                           StreetAddress, City, State, ZipCode, ContactPhone FROM Member WHERE 
                          (@MemberID IS NULL OR MemberID = @MemberID) AND
                          (@ContactPhone IS NULL OR ContactPhone = @ContactPhone) AND
                          (@LastName IS NULL OR LastName = @LastName) AND
                          (@FirstName IS NULL OR FirstName = @FirstName)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = string.IsNullOrEmpty(memberId) ? (object)DBNull.Value : Convert.ToInt32(memberId);
                    command.Parameters.Add("@ContactPhone", SqlDbType.VarChar, 20).Value = string.IsNullOrEmpty(contactPhone) ? (object)DBNull.Value : contactPhone;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(lastName) ? (object)DBNull.Value : lastName;
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(firstName) ? (object)DBNull.Value : firstName;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
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
                            });
                        }
                    }
                }
            }
            return customers;
        }

        /// <summary>
        /// Customers the exists.
        /// </summary>
        /// <param name="contactPhone">The contact phone.</param>
        /// <returns></returns>
        public bool CustomerExists(string contactPhone)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"
            SELECT COUNT(1)
            FROM Member
            WHERE ContactPhone = @ContactPhone";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ContactPhone", SqlDbType.NVarChar).Value = contactPhone;
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();
                    return userCount > 0;
                }
            }
        }


        /// <summary>
        /// Edits the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns></returns>
        public bool UpdateCustomer(Customer customer)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"
                       UPDATE Member
                       SET LastName = @LastName,
                           FirstName = @FirstName,
                           Sex = @Sex,
                           DateOfBirth = @DateOfBirth,
                           StreetAddress = @StreetAddress,
                           City = @City,
                           State = @State,
                           ZipCode = @ZipCode,
                           ContactPhone = @ContactPhone
                       WHERE MemberID = @MemberID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = customer.MemberID;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = customer.LastName;
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = customer.FirstName;
                    command.Parameters.Add("@Sex", SqlDbType.NChar).Value = customer.Sex; 
                    command.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = customer.DateOfBirth;
                    command.Parameters.Add("@StreetAddress", SqlDbType.NVarChar).Value = customer.StreetAddress;
                    command.Parameters.Add("@City", SqlDbType.NVarChar).Value = customer.City;
                    command.Parameters.Add("@State", SqlDbType.NVarChar).Value = customer.State;
                    command.Parameters.Add("@ZipCode", SqlDbType.NVarChar).Value = customer.ZipCode;
                    command.Parameters.Add("@ContactPhone", SqlDbType.NVarChar).Value = customer.ContactPhone;

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result == 1;
                }
            }
        }
    }
}
