using FurnitureDepot.DAL;

namespace FurnitureDepot.Controller
{
    /// <summary>
    /// Employee Controller Class
    /// </summary>
    public class EmployeeController
    {
        private readonly EmployeeDAL _employeeDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        public EmployeeController()
        {
            _employeeDAL = new EmployeeDAL();
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

        /// <summary>
        /// Gets the employee identifier by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public int GetEmployeeIdByUsername(string username)
        {
            return _employeeDAL.GetEmployeeIdByUsername(username);
        }

    }
}
