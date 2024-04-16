namespace FurnitureDepot.Model
{
    /// <summary>
    /// ReportData Class
    /// </summary>
    public class ReportData
    {
        public int FurnitureID { get; set; }
        public string FurnitureCategory { get; set; }
        public string FurnitureName { get; set; }
        public int TotalTransactions { get; set; }
        public int TotalAllTransactions { get; set; }
        public decimal PercentageOfTotalRentals { get; set; }
        public decimal PercentageAged18to29 { get; set; }
        public decimal PercentageOutside18to29 { get; set; }
    }
}
