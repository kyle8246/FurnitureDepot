using System;
using System.Collections.Generic;

namespace FurnitureDepot.Model
{
    /// <summary>
    /// Rental Class
    /// </summary>
    internal class Rental
    {
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
        public List<RentalItem> RentalItems { get; set; }
    }
}
