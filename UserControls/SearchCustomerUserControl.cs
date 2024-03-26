using FurnitureDepot.Controller;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FurnitureDepot.UserControls
{
    /// <summary>
    /// Search Customer User Control Class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchCustomerUserControl : UserControl
    {
        public event EventHandler<int> CustomerSelected;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCustomerUserControl"/> class.
        /// </summary>
        public SearchCustomerUserControl()
        {
            InitializeComponent();
            searchDataGridView.CellClick += SearchDataGridView_CellClick;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text.Trim();
            string phone = phoneTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string firstName = firstNameTextBox.Text.Trim();

            if (!ValidateSearchCriteria(id, phone, lastName, firstName))
            {
                messageLabel.Text = "Search Criteria: ID/Phone/Last and First Name";
                messageLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                messageLabel.Text = "";
            }

            if (!string.IsNullOrWhiteSpace(id) && (!int.TryParse(idTextBox.Text, out int customerID) || customerID <= 0))
            {
                messageLabel.Text = "Enter a valid ID";
                messageLabel.ForeColor = Color.Red;
                return;
            }

            if (!string.IsNullOrWhiteSpace(phone) && (phoneTextBox.Text.Length != 10 || !phoneTextBox.Text.All(char.IsDigit)))
            {
                messageLabel.Text = "Phone number must be 10 digits";
                messageLabel.ForeColor = Color.Red;
                return;
            }

            CustomerController customerController = new CustomerController();
            var customers = customerController.SearchCustomers(id, phone, lastName, firstName);

            if (customers == null || customers.Count == 0)
            {
                messageLabel.Text = "No results found";
                messageLabel.ForeColor = Color.Red;
                searchDataGridView.DataSource = null;
            }
            else
            {
                searchDataGridView.DataSource = customers;
                messageLabel.Text = "";
            }
        }

        private void SearchDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dataGridView = sender as DataGridView;
                var row = dataGridView.Rows[e.RowIndex];
                int customerId = Convert.ToInt32(row.Cells["MemberID"].Value);

                CustomerSelected?.Invoke(this, customerId);
            }
        }

        private bool ValidateSearchCriteria(string id, string phone, string lastName, string firstName)
        {
            return !string.IsNullOrWhiteSpace(id) ||
                   !string.IsNullOrWhiteSpace(phone) ||
                   (!string.IsNullOrWhiteSpace(lastName) && !string.IsNullOrWhiteSpace(firstName));
        }

        private void ClearForm()
        {
            searchDataGridView.DataSource = null;
            messageLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            phoneTextBox.Clear();
            lastNameTextBox.Clear();
            firstNameTextBox.Clear();
            ClearForm();
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            phoneTextBox.Clear();
            lastNameTextBox.Clear();
            firstNameTextBox.Clear();
            ClearForm();
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            idTextBox.Clear();
            lastNameTextBox.Clear();
            firstNameTextBox.Clear();
            ClearForm();
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            idTextBox.Clear();
            phoneTextBox.Clear();
            ClearForm();
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            idTextBox.Clear();
            phoneTextBox.Clear();
            ClearForm();
        }
    }
}
