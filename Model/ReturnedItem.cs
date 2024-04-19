namespace FurnitureDepot.Model
{
    /// <summary>
    /// Model of a returned item
    /// </summary>
    public class ReturnedItem
    {
        public int ReturnedItemID { get; set; }
        public int ReturnTransactionID { get; set; }
        public int RentalItemID { get; set; }
        public int QuantityReturned { get; set; }
    }

}
