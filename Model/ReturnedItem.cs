namespace FurnitureDepot.Model
{
    /// <summary>
    /// Returned Item Class
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
    }
}
