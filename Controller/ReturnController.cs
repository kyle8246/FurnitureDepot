using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using System.Collections.Generic;

namespace FurnitureDepot.Controller
{
    public class ReturnController
    {
        private readonly ReturnDAL _returnDAL;

        public ReturnController()
        {
            _returnDAL = new ReturnDAL();
        }

        public List<RentalItem> GetRentalItemsForReturnByTransactionId(int rentalTransactionID)
        {
            return _returnDAL.GetRentalItemsByTransactionId(rentalTransactionID);
        }
    }
}
