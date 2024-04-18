using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using System.Collections.Generic;

namespace FurnitureDepot.Controller
{
    /// <summary>
    /// Controller to manage returns
    /// </summary>
    public class ReturnController
    {
        private readonly ReturnDAL _returnDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnController"/> class.
        /// </summary>
        public ReturnController()
        {
            _returnDAL = new ReturnDAL();
        }

        /// <summary>
        /// Gets the rental items for return by transaction identifier.
        /// </summary>
        /// <param name="rentalTransactionID">The rental transaction identifier.</param>
        /// <returns></returns>
        public List<RentalItem> GetRentalItemsForReturnByTransactionId(int rentalTransactionID)
        {
            return _returnDAL.GetRentalItemsByTransactionId(rentalTransactionID);
        }

        /// <summary>
        /// Processes the returns.
        /// </summary>
        /// <param name="itemsToReturn">The items to return.</param>
        /// <param name="returnTransactionID">The return transaction identifier.</param>
        /// <returns></returns>
        public bool ProcessReturns(List<RentalItem> itemsToReturn, int returnTransactionID)
        {
            return _returnDAL.ProcessReturns(itemsToReturn, returnTransactionID);
        }

    }
}
