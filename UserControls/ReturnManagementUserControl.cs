using FurnitureDepot.Controller;
using FurnitureDepot.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FurnitureDepot.Utilities;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FurnitureDepot.UserControls
{
    /// <summary>
    /// Return Management Class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ReturnManagementUserControl : UserControl
    {
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
            employeeController = new EmployeeController();
            this.searchButton.Click += new EventHandler(SearchButton_Click);
            returnTransactionDataGridView.DataError += ReturnTransactionDataGridView_DataError;
            returnTransactionDataGridView.CurrentCellDirtyStateChanged += new EventHandler(ReturnTransactionDataGridView_CurrentCellDirtyStateChanged);
            returnTransactionDataGridView.CellValueChanged += new DataGridViewCellEventHandler(ReturnTransactionDataGridView_CellValueChanged);
            InitializeDataGridView();
            this.clearButton.Click += new EventHandler(ClearButton_Click);
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

        private void SearchButton_Click(object sender, EventArgs e)
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
                    currentOrderCustomer = customer;

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
                bool transactionComplete = returnController.IsRentalTransactionComplete(rental.RentalTransactionID);
                var rentalItems = returnController.GetRentalItemsForReturnByTransactionId(rental.RentalTransactionID);

                foreach (var item in rentalItems)
                {
                    int rowIndex = returnTransactionDataGridView.Rows.Add();
                    var row = returnTransactionDataGridView.Rows[rowIndex];

                    row.Cells["selectColumn"].Value = false;
                    row.Cells["transactionIDColumn"].Value = rental.RentalTransactionID;
                    row.Cells["itemIDColumn"].Value = item.RentalItemID;
                    row.Cells["itemNameColumn"].Value = item.FurnitureName;
                    row.Cells["rentedQuantityColumn"].Value = item.Quantity;
                    row.Cells["dueDateColumn"].Value = rental.DueDate.ToString("d");
                    row.Cells["dailyRateColumn"].Value = item.DailyRate.ToString("C2");

                    if (transactionComplete)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        row.ReadOnly = true;
                        var completedCell = new DataGridViewTextBoxCell();
                        completedCell.Value = "Completed";
                        row.Cells["selectColumn"] = completedCell;
                    }
                    else
                    {
                        DataGridViewComboBoxCell comboBoxCell = row.Cells["returnQuantityColumn"] as DataGridViewComboBoxCell;
                        comboBoxCell.Items.Clear();
                        for (int i = 0; i <= item.Quantity; i++)
                        {
                            comboBoxCell.Items.Add(i);
                        }
                        comboBoxCell.Value = comboBoxCell.Items[0];
                    }
                }
            }

            returnTransactionDataGridView.Refresh();
        }


        private void ReturnTransactionDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

        private void ReturnTransactionDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (returnTransactionDataGridView.IsCurrentCellDirty)
            {
                returnTransactionDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void ReturnTransactionDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            returnTransactionDataGridView.Rows.Clear();
            customerNameLabel.Text = "";
            customerIDTextBox.Text = "";
            feesValueLabel.Text = "";
            currentOrderCustomer = null;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            returnTransactionDataGridView.Rows.Clear();
            customerNameLabel.Text = "";
            customerIDTextBox.Text = "";
            feesValueLabel.Text = "";
            currentOrderCustomer = null;
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            returnTransactionDataGridView.Rows.Clear();
            customerNameLabel.Text = "";
            customerIDTextBox.Text = "";
            feesValueLabel.Text = "";
            currentOrderCustomer = null;
        }

        private void CalculateReturnFees()
        {
            decimal totalFees = 0m;

            foreach (DataGridViewRow row in returnTransactionDataGridView.Rows)
            {
                if (row.Cells["selectColumn"].Value is bool isSelected &&
                    isSelected &&
                    int.TryParse(row.Cells["returnQuantityColumn"].Value?.ToString(), out int returnQuantity) &&
                    returnQuantity > 0)
                {
                    if (Decimal.TryParse(row.Cells["dailyRateColumn"].Value?.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal dailyRate) &&
                        DateTime.TryParse(row.Cells["dueDateColumn"].Value?.ToString(), CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime dueDate))
                    {
                        int daysDifference = (DateTime.Now.Date - dueDate.Date).Days;
                        decimal feeForThisItem = daysDifference * dailyRate * returnQuantity;
                        totalFees += feeForThisItem;
                    }
                }
            }

            feesValueLabel.Text = totalFees.ToString("C2");
        }

        private void ProcessReturnButton_Click(object sender, EventArgs e)
        {
            var itemsToReturn = new List<RentalItem>();

            foreach (DataGridViewRow row in returnTransactionDataGridView.Rows)
            {

                if (row.Cells["selectColumn"].Value.ToString() == "Completed")
                    continue;

                if (Convert.ToBoolean(row.Cells["selectColumn"].Value))
                {
                    if (int.TryParse(row.Cells["returnQuantityColumn"].Value?.ToString(), out int returnQuantity) && returnQuantity > 0)
                    {
                        var rentalItem = returnController.GetRentalItemForReturnByRentalItemID(Convert.ToInt32(row.Cells["itemIDColumn"].Value));
                        if (rentalItem != null)
                        {
                            rentalItem.QuantityReturned = returnQuantity;
                            itemsToReturn.Add(rentalItem);
                        }
                    }
                }
            }
            if (itemsToReturn.Count == 0)
            {
                MessageBox.Show("No items selected for return.", "Return Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to process the selected returns?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            int employeeID = SessionManager.CurrentEmployeeID;
            int memberID = currentOrderCustomer.MemberID;

            ReturnProcessResult returnProcessResult = returnController.CompleteReturnProcess(employeeID, memberID, itemsToReturn);
            if (returnProcessResult.IsSuccessful)
            {
                MessageBox.Show("Return processed successfully.", "Return Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridViewPostReturn(itemsToReturn);
                DisplayReturnReceipt(returnProcessResult.ReturnTransactionID);
            }
            else
            {
                MessageBox.Show($"Failed to process return: {returnProcessResult.ErrorMessage}", "Return Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridViewPostReturn(List<RentalItem> itemsToReturn)
        {
            int rentalTransactionID = itemsToReturn.First().RentalTransactionID;

            if (returnController.IsRentalTransactionComplete(rentalTransactionID))
            {
                foreach (DataGridViewRow row in returnTransactionDataGridView.Rows)
                {
                    if (Convert.ToInt32(row.Cells["transactionIDColumn"].Value) == rentalTransactionID)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        row.ReadOnly = true;
                        var completedCell = new DataGridViewTextBoxCell();
                        completedCell.Value = "Completed";
                        row.Cells["selectColumn"] = completedCell;
                        row.Cells["returnQuantityColumn"].Value = String.Empty;
                    }
                }
            }
        }

        private void DisplayReturnReceipt(int returnTransactionId)
        {
            ReturnTransaction returnTransaction = returnController.GetReturnTransactionByID(returnTransactionId);
            if (returnTransaction == null)
            {
                MessageBox.Show("Error retrieving return transaction data.", "Receipt Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string customerName = customerController.GetCustomerFullNameById(returnTransaction.MemberID);
            string employeeName = employeeController.GetEmployeeFullNameById(returnTransaction.EmployeeID);

            List<ReturnedItem> returnedItems = returnController.GetReturnedItemsByTransactionId(returnTransactionId);

            StringBuilder receiptText = new StringBuilder();
            receiptText.AppendLine("Return Transaction Receipt");
            receiptText.AppendLine("----------------------------");
            receiptText.AppendLine($"Return Transaction ID: {returnTransaction.ReturnTransactionID}");
            receiptText.AppendLine($"Customer: {customerName}");
            receiptText.AppendLine($"Processed by: {employeeName}");
            receiptText.AppendLine($"Return Date: {returnTransaction.ReturnDate:d}");

            decimal totalFees = 0m;
            receiptText.AppendLine("\nItems Returned:");

            foreach (var item in returnedItems)
            {
                decimal feeForThisItem = CalculateReturnFeeForItem(item);
                totalFees += feeForThisItem;

                receiptText.AppendLine($"ID: {item.RentalItemID} - {item.FurnitureName} x{item.QuantityReturned} @ {item.DailyRate:C} per day - Fee: {feeForThisItem:C}");
            }

            receiptText.AppendLine("\nTotal Fees: " + $"{totalFees:C}");

            MessageBox.Show(receiptText.ToString(), "Return Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private decimal CalculateReturnFeeForItem(ReturnedItem item)
        {
            if (!item.RentalItemID.HasValue)
            {
                throw new InvalidOperationException("RentalItemID is null for the returned item.");
            }
            int rentalItemID = item.RentalItemID.Value;

            RentalItem rentalItem = returnController.GetRentalItemForReturnByRentalItemID(rentalItemID);
            if (rentalItem == null)
            {
                throw new InvalidOperationException("Rental item not found for the given returned item.");
            }

            RentalTransaction rentalTransaction = rentalController.GetRentalTransactionById(rentalItem.RentalTransactionID);
            if (rentalTransaction == null)
            {
                throw new InvalidOperationException("Rental transaction not found for the given rental item.");
            }

            int daysLate = (DateTime.Now.Date - rentalTransaction.DueDate).Days;
            decimal lateFeeRate = item.DailyRate * 2;
            decimal fee = daysLate > 0 ? daysLate * lateFeeRate : 0m;
            return fee;
        }

    }
}
