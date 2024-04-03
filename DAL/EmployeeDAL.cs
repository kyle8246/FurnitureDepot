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
    }
}
