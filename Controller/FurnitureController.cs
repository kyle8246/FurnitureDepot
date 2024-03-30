using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using System.Collections.Generic;

namespace FurnitureDepot.Controller
{
    /// <summary>
    /// Controller to manage furniture
    /// </summary>
    public class FurnitureController
    {

        private readonly FurnitureDAL _furnitureDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureController"/> class.
        /// </summary>
        public FurnitureController()
        {
            _furnitureDAL = new FurnitureDAL();
        }

        public List<Furniture> GetAllFurnitureItems()
        {
            return _furnitureDAL.GetAllFurnitureItems();
        }

    }
}
