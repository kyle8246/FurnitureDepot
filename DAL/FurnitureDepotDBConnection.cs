using System.Data.SqlClient;

namespace FurnitureDepot.DAL
{
    /// <summary>
    /// Get a connection object. 
    /// </summary>
    public class FurnitureDepotDBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=cs6232-g2;" +
                // "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=cs6232-g2;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
