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
            this.dashboardTabControl.Selected += new TabControlEventHandler(DashboardTabControl_Selected);
            RegisterCustomerUserControl registerCustomerControl = new RegisterCustomerUserControl();
            registerCustomerControl.Dock = DockStyle.Fill;
            registrationTabPage.Controls.Add(registerCustomerControl);
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

        private void DashboardTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == registrationTabPage && e.TabPage.Controls.Count == 0)
            {
                RegisterCustomerUserControl registerCustomerControl = new RegisterCustomerUserControl();
                registerCustomerControl.Dock = DockStyle.Fill;
                registrationTabPage.Controls.Add(registerCustomerControl);
            }

            this.editCustomerUserControl?.Clear();
        }

    }
}
