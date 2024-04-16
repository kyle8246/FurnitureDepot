using System;

namespace FurnitureDepot.Model
{
    /// <summary>
    /// RentalTransaction Class
    /// </summary>
    public class RentalTransaction
    {
        public int RentalTransactionID { get; set; }
        public int MemberID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalCost { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
    }
}
