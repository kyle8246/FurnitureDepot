using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using System.Collections.Generic;

namespace FurnitureDepot.Controller
{
    /// <summary>
    /// RentalController Class
    /// </summary>
    public class RentalController
    {
        private readonly RentalDAL _rentalDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalController"/> class.
        /// </summary>
        public RentalController()
        {
            _rentalDAL = new RentalDAL();
        }

        /// <summary>
        /// Gets the rental transactions by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public List<RentalTransaction> GetRentalTransactionsByMemberID(int memberID)
        {
            return _rentalDAL.GetRentalTransactionsByMemberID(memberID);
        }

        /// <summary>
        /// Gets the rental items by transaction identifier.
        /// </summary>
        /// <param name="rentalTransactionID">The rental transaction identifier.</param>
        /// <returns></returns>
        public List<RentalItem> GetRentalItemsByTransactionId(int rentalTransactionID)
        {
            return _rentalDAL.GetRentalItemsByTransactionId(rentalTransactionID);
        }

        /// <summary>
        /// Inserts the rental transaction.
        /// </summary>
        /// <param name="transaction">The transaction.</param>
        /// <returns></returns>
        public int InsertRentalTransaction(RentalTransaction transaction)
        {
            return _rentalDAL.InsertRentalTransaction(transaction);
        }

        /// <summary>
        /// Inserts the rental items.
        /// </summary>
        /// <param name="items">The items.</param>
        public void InsertRentalItems(List<RentalItem> items)
        {
            _rentalDAL.InsertRentalItems(items);
        }

        /// <summary>
        /// Gets the rental transaction by identifier.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns></returns>
        public RentalTransaction GetRentalTransactionById(int transactionId)
        {
            return _rentalDAL.GetRentalTransactionById(transactionId);
        }
    }
}
