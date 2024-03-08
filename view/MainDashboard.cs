using System.Windows.Forms;

namespace FurnitureDepot.View
{
    /// <summary>
    /// Main Dashboard Class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainDashboard : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashboard"/> class.
        /// </summary>
        public MainDashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the user.
        /// </summary>
        /// <param name="username">The username.</param>
        public void SetUser(string username)
        {
            this.usernameLabel.Text = username;
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
