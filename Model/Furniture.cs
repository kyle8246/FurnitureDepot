using System;
using System.ComponentModel.DataAnnotations;

namespace FurnitureDepot.Model
{
    /// <summary>
    /// Class to model Furniture
    /// </summary>
    public class Furniture
    {
        /// <summary>
        /// Gets or sets the furniture identifier.
        /// </summary>
        /// <value>
        /// The furniture identifier.
        /// </value>
        public int FurnitureID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

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
        /// Gets or sets the daily rental rate.
        /// </summary>
        /// <value>
        /// The daily rental rate.
        /// </value>
        public decimal? DailyRentalRate { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets the in stock number.
        /// </summary>
        /// <value>
        /// The in stock number.
        /// </value>
        public int? InStockNumber { get; set; }
    }
}
