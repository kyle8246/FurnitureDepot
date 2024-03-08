using System;
using System.Data.SqlClient;
using System.Data;

namespace FurnitureDepot.DAL
{
    /// <summary>
    /// Login DAL Class
    /// </summary>
    public class LoginDAL
    {
        /// <summary>
        /// Authenticates the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Authenticate(string username, string password)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = "SELECT COUNT(1) FROM Login WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50) { Value = username });
                command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 255) { Value = password });

                connection.Open();
                int result = Convert.ToInt32(command.ExecuteScalar());
                return result == 1;
            }
        }
    }
}
