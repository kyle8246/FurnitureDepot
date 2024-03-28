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
                string query = "SELECT Password FROM Login WHERE Username = @Username";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50) { Value = username });

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string storedHash = result.ToString();
                    return BCrypt.Net.BCrypt.Verify(password, storedHash);
                }
                return false;
            }
        }
    }
}
