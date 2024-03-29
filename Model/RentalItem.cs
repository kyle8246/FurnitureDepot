namespace FurnitureDepot.Model
{
    /// <summary>
    /// RentalItem Class
    /// </summary>
    internal class RentalItem
    {
        public int RentalItemId { get; set; }
        public int FurnitureId { get; set; }
        public string FurnitureName { get; set; }
        public string Description { get; set; }
        public decimal DailyRentalRate { get; set; }
        public int Quantity { get; set; }
    }
}
