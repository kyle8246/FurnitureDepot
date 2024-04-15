using FurnitureDepot.Controller;
using FurnitureDepot.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FurnitureDepot.Utilities;
using System.Text;
using FurnitureDepot.DAL;
using System.Data.SqlClient;

namespace FurnitureDepot.UserControls
{
    public partial class ReturnTransactionUserControl : UserControl
    {
        private FurnitureController furnitureController;
        private CustomerController customerController;
        private Customer currentOrderCustomer;
        private RentalController rentalController;
        private EmployeeController employeeController;

        public ReturnTransactionUserControl()
        {
            InitializeComponent();
            customerController = new CustomerController();
            rentalController = new RentalController();
            this.searchButton.Click += new EventHandler(searchButton_Click);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int customerId;
            if (int.TryParse(customerIDTextBox.Text, out customerId))
            {
                var customer = customerController.GetCustomerByMemberID(customerId);
                if (customer != null)
                {
                    customerNameLabel.Text = $"Customer Name: {customer.LastName}, {customer.FirstName}";
                    customerNameLabel.ForeColor = Color.Black;

                    var rentals = rentalController.GetRentalTransactionsByMemberID(customerId);

                    PopulateRentalsDataGridView(rentals);
                }
                else
                {
                    customerNameLabel.Text = "Customer not found.";
                    customerNameLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                customerNameLabel.Text = "Invalid Customer ID.";
                customerNameLabel.ForeColor = Color.Red;
            }
        }
       
        private void PopulateRentalsDataGridView(List<RentalTransaction> rentals)
        {
            /*
            returnlTransactionDataGridView.Rows.Clear();

            foreach (var rental in rentals)
            {
                int rowIndex = returnlTransactionDataGridView.Rows.Add();
                var row = returnlTransactionDataGridView.Rows[rowIndex];
                row.Cells["TransactionIDColumn"].Value = rental.RentalTransactionID;
                row.Cells["DateRentedColumn"].Value = rental.RentalDate;
            }
            */
        }
      
    }
}
