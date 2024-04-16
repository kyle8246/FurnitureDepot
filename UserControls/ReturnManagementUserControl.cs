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
using System.Globalization;

namespace FurnitureDepot.UserControls
{
    /// <summary>
    /// Return Management Class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ReturnManagementUserControl : UserControl
    {
        private FurnitureController furnitureController;
        private CustomerController customerController;
        private Customer currentOrderCustomer;
        private RentalController rentalController;
        private EmployeeController employeeController;
        private ReturnController returnController;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnManagementUserControl"/> class.
        /// </summary>
        public ReturnManagementUserControl()
        {
            InitializeComponent();
            customerController = new CustomerController();
            rentalController = new RentalController();
            returnController = new ReturnController();
            this.searchButton.Click += new EventHandler(searchButton_Click);
            returnTransactionDataGridView.DataError += returnTransactionDataGridView_DataError;
            returnTransactionDataGridView.CurrentCellDirtyStateChanged += new EventHandler(returnTransactionDataGridView_CurrentCellDirtyStateChanged);
            returnTransactionDataGridView.CellValueChanged += new DataGridViewCellEventHandler(returnTransactionDataGridView_CellValueChanged);
            InitializeDataGridView();
            this.clearButton.Click += new EventHandler(clearButton_Click);
        }

        private void InitializeDataGridView()
        {
            var returnQuantityColumn = returnTransactionDataGridView.Columns["returnQuantityColumn"] as DataGridViewComboBoxColumn;
            if (returnQuantityColumn != null)
            {
                returnQuantityColumn.ValueType = typeof(int);
            }
            returnTransactionDataGridView.Columns["dailyRateColumn"].DefaultCellStyle.Format = "C2";
            returnTransactionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            returnTransactionDataGridView.Rows.Clear();

            foreach (var rental in rentals)
            {
                var rentalItems = returnController.GetRentalItemsForReturnByTransactionId(rental.RentalTransactionID);

                foreach (var item in rentalItems)
                {
                    int rowIndex = returnTransactionDataGridView.Rows.Add();
                    var row = returnTransactionDataGridView.Rows[rowIndex];

                    row.Cells["selectColumn"].Value = false;
                    row.Cells["transactionIDColumn"].Value = rental.RentalTransactionID;
                    row.Cells["itemIDColumn"].Value = item.FurnitureID;
                    row.Cells["itemNameColumn"].Value = item.FurnitureName;
                    row.Cells["rentedQuantityColumn"].Value = item.Quantity;
                    row.Cells["dueDateColumn"].Value = rental.DueDate.ToShortDateString();
                    row.Cells["dailyRateColumn"].Value = item.DailyRate.ToString("C2");

                    DataGridViewComboBoxCell comboBoxCell = row.Cells["returnQuantityColumn"] as DataGridViewComboBoxCell;
                    comboBoxCell.Items.Clear();
                    for (int i = 0; i <= item.Quantity; i++)
                    {
                        comboBoxCell.Items.Add(i);
                    }
                    comboBoxCell.Value = comboBoxCell.Items[0];
                    returnTransactionDataGridView.Refresh();
                }
            }
        }

        private void returnTransactionDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == returnTransactionDataGridView.Columns["returnQuantityColumn"].Index)
            {
                e.ThrowException = false;
                e.Cancel = false;

                Console.WriteLine("Data Error: " + e.Exception.Message);
            }
            else
            {
                MessageBox.Show("Data Error: " + e.Exception.Message);
                e.Cancel = true;
            }
        }

        private void returnTransactionDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (returnTransactionDataGridView.IsCurrentCellDirty)
            {
                returnTransactionDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void returnTransactionDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == returnTransactionDataGridView.Columns["returnQuantityColumn"].Index)
            {
                returnTransactionDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            if (e.ColumnIndex == returnTransactionDataGridView.Columns["selectColumn"].Index ||
                e.ColumnIndex == returnTransactionDataGridView.Columns["returnQuantityColumn"].Index)
            {
                CalculateReturnFees();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            returnTransactionDataGridView.Rows.Clear();
            customerNameLabel.Text = "";
            customerIDTextBox.Text = "";
            feesValueLabel.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            returnTransactionDataGridView.Rows.Clear();
            customerNameLabel.Text = "";
            customerIDTextBox.Text = "";
            feesValueLabel.Text = "";
        }

        public void Clear()
        {
            returnTransactionDataGridView.Rows.Clear();
            customerNameLabel.Text = "";
            customerIDTextBox.Text = "";
            feesValueLabel.Text = "";
        }

        private void CalculateReturnFees()
        {
            decimal totalFees = 0m;

            foreach (DataGridViewRow row in returnTransactionDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["selectColumn"].Value) &&
                    row.Cells["returnQuantityColumn"].Value != null &&
                    int.TryParse(row.Cells["returnQuantityColumn"].Value.ToString(), out int returnQuantity) &&
                    returnQuantity > 0)
                {
                    if (Decimal.TryParse(row.Cells["dailyRateColumn"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal dailyRate) &&
                        DateTime.TryParse(row.Cells["dueDateColumn"].Value.ToString(), out DateTime dueDate))
                    {
                        int daysDifference = (DateTime.Now.Date - dueDate.Date).Days;
                        decimal feeForThisItem = daysDifference * dailyRate * returnQuantity;
                        totalFees += feeForThisItem;
                    }
                }
            }

            feesValueLabel.Text = $"{totalFees:C2}";
        }

    }
}
