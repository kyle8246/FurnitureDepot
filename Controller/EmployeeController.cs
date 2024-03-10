﻿using FurnitureDepot.DAL;
using FurnitureDepot.Model;

namespace FurnitureDepot.Controller
{
    /// <summary>
    /// Employee Controller Class
    /// </summary>
    public class EmployeeController
    {
        private readonly EmployeeDAL _employeeDAL;
        private readonly CustomerDAL _customerDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        public EmployeeController()
        {
            _employeeDAL = new EmployeeDAL();
            _customerDAL = new CustomerDAL();
        }

        /// <summary>
        /// Gets the full name of the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public string GetUserFullName(string username)
        {
            return _employeeDAL.GetUserFullName(username);
        }

        public Customer GetCustomerByMemberID(int memberID)
        {
            return _customerDAL.GetCustomerByMemberID(memberID);
        }
    }
}
