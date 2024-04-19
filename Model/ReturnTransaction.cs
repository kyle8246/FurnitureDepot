using System;

namespace FurnitureDepot.Model
{
    /// <summary>
    /// Return Transaction Class
    /// </summary>
    public class ReturnTransaction

    {
        public int ReturnTransactionID { get; set; }
        public int EmployeeID { get; set; }
        public int MemberID { get; set; }
        public DateTime? ReturnDate { get; set; }
    }

}