using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

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
        /// Completes the return process.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="itemsToReturn">The items to return.</param>
        /// <returns></returns>
        public bool CompleteReturnProcess(int employeeID, int memberID, List<RentalItem> itemsToReturn)
        {
            return _returnDAL.CompleteReturnProcess(employeeID, memberID, itemsToReturn);
        }

        /// <summary>
        /// Creates the return transaction.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns></returns>
        public int CreateReturnTransaction(int employeeID, int memberID, SqlTransaction transaction)
        {
            return _returnDAL.CreateReturnTransaction(employeeID, memberID, transaction);
        }

    }
}
