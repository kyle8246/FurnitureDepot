using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using System.Collections.Generic;

namespace FurnitureDepot.Controller
{
    /// <summary>
    /// Return Controller
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
        /// Gets the return transactions by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public List<ReturnTransaction> GetReturnTransactionsByMemberID(int memberID)
        {
            return _returnDAL.GetReturnTransactionsByMemberID(memberID);
        }

        /// <summary>
        /// Gets the returned items by transaction identifier.
        /// </summary>
        /// <param name="returnTransactionID">The return transaction identifier.</param>
        /// <returns></returns>
        public List<ReturnedItem> GetReturnedItemsByTransactionId(int returnTransactionID)
        {
            return _returnDAL.GetReturnedItemsByTransactionId(returnTransactionID);
        }
    }
}
