using FurnitureDepot.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace FurnitureDepot.DAL
{
    /// <summary>
    /// ReportDAL Class
    /// </summary>
    public class ReportDAL
    {
        /// <summary>
        /// Gets the report data.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public List<ReportData> GetReportData(DateTime startDate, DateTime endDate)
        {
            List<ReportData> reportList = new List<ReportData>();

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("getMostPopularFurnitureDuringDates", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@startDate", SqlDbType.Date) { Value = startDate });
                    cmd.Parameters.Add(new SqlParameter("@endDate", SqlDbType.Date) { Value = endDate });

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var reportData = new ReportData
                            {
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                FurnitureCategory = reader.GetString(reader.GetOrdinal("FurnitureCategory")),
                                FurnitureName = reader.GetString(reader.GetOrdinal("FurnitureName")),
                                TotalTransactions = reader.GetInt32(reader.GetOrdinal("TotalTransactions")),
                                TotalAllTransactions = reader.GetInt32(reader.GetOrdinal("TotalAllTransactions")),
                                PercentageOfTotalRentals = reader.GetDecimal(reader.GetOrdinal("PercentageOfTotalRentals")),
                                PercentageAged18to29 = reader.GetDecimal(reader.GetOrdinal("PercentageAged18to29")),
                                PercentageOutside18to29 = reader.GetDecimal(reader.GetOrdinal("PercentageOutside18to29"))
                            };

                            reportList.Add(reportData);
                        }
                    }
                }
            }

            return reportList;
        }
    }
}
