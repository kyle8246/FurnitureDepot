using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using System;
using System.Collections.Generic;

namespace FurnitureDepot.Controller
{
    /// <summary>
    /// ReportController Class
    /// </summary>
    public class ReportController
    {
        private readonly ReportDAL _reportDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportController"/> class.
        /// </summary>
        public ReportController()
        {
            _reportDAL = new ReportDAL();
        }

        /// <summary>
        /// Gets the report data.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public List<ReportData> GetReportData(DateTime startDate, DateTime endDate)
        {
            return _reportDAL.GetReportData(startDate, endDate);
        }
    }
}
