using FurnitureDepot.DAL;
using FurnitureDepot.Model;

namespace FurnitureDepot.Controller
{
    /// <summary>
    /// Customer Controller
    /// </summary>
    public class CustomerController
    {
        private readonly CustomerDAL customerDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerController"/> class.
        /// </summary>
        public CustomerController()
        {
            customerDAL = new CustomerDAL();
        }

        /// <summary>
        /// Registers the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns></returns>
        public bool RegisterCustomer(Customer customer)
        {
            return customerDAL.AddCustomer(customer);
        }
    }
}