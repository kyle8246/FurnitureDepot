using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using FurnitureDepot.Utilities;
using System.Collections.Generic;
using System.Data.SqlClient;

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
        /// Gets the return transactions by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>List of return transactions.</returns>
        public List<ReturnTransaction> GetReturnTransactionsByMemberID(int memberID)
        {
            return _returnDAL.GetReturnTransactionsByMemberID(memberID);
        }

        /// <summary>
        /// Gets the returned items by transaction identifier.
        /// </summary>
        /// <param name="returnTransactionID">The return transaction identifier.</param>
        /// <returns>List of returned items.</returns>
        public List<ReturnedItem> GetReturnedItemsByTransactionId(int returnTransactionID)
        {
            return _returnDAL.GetReturnedItemsByTransactionId(returnTransactionID);
        }

        /// <summary>
        /// Completes the return process.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="itemsToReturn">The items to return.</param>
        /// <returns>The result of the return process.</returns>
        public ReturnProcessResult CompleteReturnProcess(int employeeID, int memberID, List<RentalItem> itemsToReturn)
        {
            return _returnDAL.CompleteReturnProcess(employeeID, memberID, itemsToReturn);
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
        /// Creates the return transaction.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns>The identifier of the created return transaction.</returns>
        public int CreateReturnTransaction(int employeeID, int memberID, SqlTransaction transaction)
        {
            return _returnDAL.CreateReturnTransaction(employeeID, memberID, transaction);
        }

        /// <summary>
        /// Gets the rental item for return by rental item identifier.
        /// </summary>
        /// <param name="rentalItemID">The rental item identifier.</param>
        /// <returns>The rental item for return.</returns>
        public RentalItem GetRentalItemForReturnByRentalItemID(int rentalItemID)
        {
            return _returnDAL.GetRentalItemForReturnByRentalItemID(rentalItemID);
        }

        /// <summary>
        /// Determines whether the rental transaction is complete.
        /// </summary>
        /// <param name="rentalTransactionID">The rental transaction identifier.</param>
        /// <returns>true if the rental transaction is complete; otherwise, false.</returns>
        public bool IsRentalTransactionComplete(int rentalTransactionID)
        {
            return _returnDAL.IsRentalTransactionComplete(rentalTransactionID);
        }

        /// <summary>
        /// Gets the return transaction by identifier.
        /// </summary>
        /// <param name="returnTransactionID">The return transaction identifier.</param>
        /// <returns></returns>
        public ReturnTransaction GetReturnTransactionByID(int returnTransactionID)
        {
            return _returnDAL.GetReturnTransactionById(returnTransactionID);
        }
    }
}
