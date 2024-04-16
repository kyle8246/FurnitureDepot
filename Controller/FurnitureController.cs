using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        /// <summary>
        /// Searches the furniture.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <param name="category">The category.</param>
        /// <param name="style">The style.</param>
        /// <returns></returns>
        public List<Furniture> SearchFurniture(string furnitureID, string category, string style)
        {
            return _furnitureDAL.SearchFurniture(furnitureID, category, style);
        }

        /// <summary>
        /// Checks the in stock quantity of the furniture item.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <param name="requiredQuantity">The required quantity.</param>
        /// <returns></returns>
        public bool CheckInStock(int furnitureID, int requiredQuantity)
        {
            return _furnitureDAL.CheckInStock(furnitureID, requiredQuantity);
        }


        /// <summary>
        /// Updates the in stock number.
        /// </summary>
        /// <param name="furnitureId">The furniture identifier.</param>
        /// <param name="quantityToSubtract">The quantity to subtract.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns></returns>
        public bool UpdateInStockNumber(int furnitureId, int quantityToSubtract, SqlTransaction transaction)
        {
            return _furnitureDAL.UpdateInStockNumber(furnitureId, quantityToSubtract, transaction);
        }

        /// <summary>
        /// Gets the furniture categories.
        /// </summary>
        /// <returns></returns>
        public List<string> GetFurnitureCategories()
        {
            return _furnitureDAL.GetFurnitureCategories();
        }

        /// <summary>
        /// Gets the furniture styles.
        /// </summary>
        /// <returns></returns>
        public List<string> GetFurnitureStyles()
        {
            return _furnitureDAL.GetFurnitureStyles();
        }

        /// <summary>
        /// Searches the furniture by category and style only.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <param name="style">The style.</param>
        /// <returns></returns>
        public List<Furniture> SearchFurnitureByCategoryAndStyleOnly(string category, string style)
        {
            return _furnitureDAL.SearchFurnitureByCategoryAndStyleOnly(category, style);
        }


    }
}
