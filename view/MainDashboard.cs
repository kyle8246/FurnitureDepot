﻿using FurnitureDepot.UserControls;
using System.Windows.Forms;

namespace FurnitureDepot.View
{
    /// <summary>
    /// Main Dashboard Class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainDashboard : Form
    {

        private RegisterCustomerUserControl registerCustomerControl;

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

            searchCustomerUserControl1.CustomerSelected += SearchCustomerUserControl_CustomerSelected;
        }

        /// <summary>
        /// Sets the user.
        /// </summary>
        /// <param name="username">The username.</param>
        public void SetUser(string username)
        {
            this.usernameLabel.Text = username;
        }

        private void SearchCustomerUserControl_CustomerSelected(object sender, int customerId)
        {
            this.dashboardTabControl.SelectedTab = editTabPage;

            editCustomerUserControl.PopulateCustomerData(customerId);
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DashboardTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == searchFurnitureTabPage)
            {
                if (e.TabPage.Controls.Count == 0)
                {
                    SearchFurnitureUserControl searchFurnitureControl = new SearchFurnitureUserControl();
                    searchFurnitureControl.Dock = DockStyle.Fill;
                    e.TabPage.Controls.Add(searchFurnitureControl);
                }
            }

            if (e.TabPage == registrationTabPage && e.TabPage.Controls.Count == 0)
            {
                RegisterCustomerUserControl registerCustomerControl = new RegisterCustomerUserControl();
                registerCustomerControl.Dock = DockStyle.Fill;
                registrationTabPage.Controls.Add(registerCustomerControl);
            }

            this.editCustomerUserControl?.Clear();
            this.rentalTransactionUserControl1?.Clear();
            this.rentalTransactionUserControl1?.ClearMemberID();
            this.registerCustomerUserControl1?.ClearStatusLabel();
            this.searchCustomerUserControl1?.Clear();
            this.searchFurnitureUserControl1?.Clear();
            this.rentalHistoryUserControl1?.Clear();
            this.returnManagementUserControl1?.Clear();
        }
    }
}
