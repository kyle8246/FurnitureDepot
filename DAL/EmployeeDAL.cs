using System.Data.SqlClient;
using System.Data;

namespace FurnitureDepot.DAL
{
    /// <summary>
    /// Employee DAL Class
    /// </summary>
    public class EmployeeDAL
    {
        /// <summary>
        /// Gets the full name of the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public string GetUserFullName(string username)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"SELECT e.FirstName, e.LastName 
                                FROM Employee e
                                INNER JOIN Login l ON e.EmployeeID = l.EmployeeID
                                WHERE l.Username = @Username";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username });

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string firstName = reader["FirstName"].ToString();
                        string lastName = reader["LastName"].ToString();
                        return $"{firstName} {lastName}";
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the employee identifier by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public int GetEmployeeIdByUsername(string username)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"SELECT e.EmployeeID 
                        FROM Employee e
                        INNER JOIN Login l ON e.EmployeeID = l.EmployeeID
                        WHERE l.Username = @Username";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username });

                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return (int)result;
                }
                else
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Gets the employee full name by identifier.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        public string GetEmployeeFullNameById(int employeeId)
        {
            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                string query = @"
            SELECT FirstName, LastName 
            FROM Employee 
            WHERE EmployeeID = @EmployeeId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", employeeId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                        return $"{firstName} {lastName}";
                    }
                }
            }
            return null;
        }
    }
}
