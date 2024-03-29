namespace FurnitureDepot.Model
{
    /// <summary>
    /// RentalItem Class
    /// </summary>
    public class RentalItem
    {
        public int RentalItemID { get; set; }
        public int RentalTransactionID { get; set; }
        public int FurnitureID { get; set; }
        public string FurnitureName { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string StyleName { get; set; }
        public decimal DailyRate { get; set; }
        public int Quantity { get; set; }
        public int QuantityReturned { get; set; }
    }
}
