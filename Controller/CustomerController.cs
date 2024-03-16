using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using System.Collections.Generic;

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

        /// <summary>
        /// Searches the customers.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <param name="contactPhone">The contact phone.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
        public List<Customer> SearchCustomers(string memberId, string contactPhone, string lastName, string firstName)
        {
            return customerDAL.SearchCustomers(memberId, contactPhone, lastName, firstName);
        }

        /// <summary>
        /// Gets the customer by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public Customer GetCustomerByMemberID(int memberID)
        {
            return customerDAL.GetCustomerByMemberID(memberID);
        }

        /// <summary>
        /// Updates the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns></returns>
        public bool UpdateCustomer(Customer customer)
        {
            return customerDAL.UpdateCustomer(customer);
        }

        /// <summary>
        /// Checks if customer exists.
        /// </summary>
        /// <param name="contactPhone">The contact phone.</param>
        /// <returns></returns>
        public bool CheckIfCustomerExists(string contactPhone)
        {
            return customerDAL.CustomerExists(contactPhone);
        }
    }
}