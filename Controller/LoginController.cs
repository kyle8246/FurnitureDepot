using FurnitureDepot.DAL;

namespace FurnitureDepot.Controller
{
    /// <summary>
    /// Login Controller Class
    /// </summary>
    public class LoginController
    {
        private readonly LoginDAL _loginDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        public LoginController() { 
            _loginDAL = new LoginDAL();
        }

        /// <summary>
        /// Authenticates the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Authenticate(string username, string password)
        {
           return _loginDAL.Authenticate(username, password);
        }
    }
}
