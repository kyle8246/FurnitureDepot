namespace FurnitureDepot.Model
{
    /// <summary>
    /// Model of a returned item
    /// </summary>
    public class ReturnedItem
    {
        /// <summary>
        /// Gets or sets the returned item identifier.
        /// </summary>
        /// <value>
        /// The returned item identifier.
        /// </value>
        public int ReturnedItemID { get; set; }

        /// <summary>
        /// Gets or sets the return transaction identifier.
        /// </summary>
        /// <value>
        /// The return transaction identifier.
        /// </value>
        public int? ReturnTransactionID { get; set; }

        /// <summary>
        /// Gets or sets the rental item identifier.
        /// </summary>
        /// <value>
        /// The rental item identifier.
        /// </value>
        public int? RentalItemID { get; set; }

        /// <summary>
        /// Gets or sets the quantity returned.
        /// </summary>
        /// <value>
        /// The quantity returned.
        /// </value>
        public int? QuantityReturned { get; set; }

        /// <summary>
        /// Gets or sets the name of the furniture.
        /// </summary>
        /// <value>
        /// The name of the furniture.
        /// </value>
        public string FurnitureName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        /// <value>
        /// The name of the category.
        /// </value>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the name of the style.
        /// </summary>
        /// <value>
        /// The name of the style.
        /// </value>
        public string StyleName { get; set; }

        /// <summary>
        /// Gets or sets the daily rate.
        /// </summary>
        /// <value>
        /// The daily rate.
        /// </value>
        public decimal DailyRate { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int? Quantity { get; set; }
    }

}
