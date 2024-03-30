using FurnitureDepot.Controller;
using FurnitureDepot.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FurnitureDepot.UserControls
{
    /// <summary>
    /// User control to handle rental transactions
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class RentalTransactionUserControl : UserControl
    {
        private FurnitureController furnitureController;
        private CustomerController customerController;
        private Customer currentOrderCustomer;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalTransactionUserControl"/> class.
        /// </summary>
        public RentalTransactionUserControl()
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.customerController = new CustomerController();
            this.currentOrderCustomer = new Customer();
        }

        private void PopulateFurnitureComboBox()
        {
            List<Furniture> furnitureItems = furnitureController.GetAllFurnitureItems();
            this.furnitureComboBox.DataSource = furnitureItems;
            this.furnitureComboBox.DisplayMember = "Name";
            this.furnitureComboBox.ValueMember = "FurnitureID";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int customerID;
            if (int.TryParse(customerIDTextBox.Text, out customerID))
            {
                var customer = customerController.GetCustomerByMemberID(customerID);
                if (customer != null)
                {
                    this.customerNameLabel.Text = "Customer Name: " + customer.LastName + ", " + customer.FirstName;
                    this.customerNameLabel.ForeColor = Color.Black;
                    this.currentOrderCustomer = customer;
                }
                else
                {
                    this.customerNameLabel.ForeColor = Color.Red;
                    this.customerNameLabel.Text = "Customer not found.";
                }
            }
            else
            {
                this.customerNameLabel.Text = "Invalid Customer ID.";
                this.customerNameLabel.ForeColor = Color.Red;
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {

        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void RentalTransactionUserControl_Load(object sender, EventArgs e)
        {
            PopulateFurnitureComboBox();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.currentOrderCustomer = null;

            this.customerNameLabel.ForeColor = Color.Black;
            this.customerNameLabel.Text = "Customer Name:";
            this.customerIDTextBox.Text = string.Empty;
        }
    }
}
