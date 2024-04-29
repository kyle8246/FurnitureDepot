using System;
using System.Drawing;
using System.Windows.Forms;
using FurnitureDepot.Controller;

namespace FurnitureDepot.UserControls
{
    /// <summary>
    /// Return History User Control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ReturnHistoryUserControl : UserControl
    {
        private ReturnController returnController = new ReturnController();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnHistoryUserControl"/> class.
        /// </summary>
        public ReturnHistoryUserControl()
        {
            InitializeComponent();
            SetupDataGridView();
            this.returnHistoryDataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(ReturnHistoryDataGridView_CellFormatting);
            this.returnHistoryDataGridView.CellClick += new DataGridViewCellEventHandler(this.ReturnHistoryDataGridView_CellClick);
        }

        private void SetupDataGridView()
        {
            DataGridViewTextBoxColumn returnIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Return ID",
                Name = "ReturnTransactionID",
                DataPropertyName = "ReturnTransactionID",
                ReadOnly = true
            };
            returnHistoryDataGridView.Columns.Add(returnIdColumn);

            DataGridViewTextBoxColumn employeeIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Employee ID",
                Name = "EmployeeID",
                DataPropertyName = "EmployeeID",
                ReadOnly = true
            };
            returnHistoryDataGridView.Columns.Add(employeeIdColumn);

            DataGridViewTextBoxColumn memberIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Member ID",
                Name = "MemberID",
                DataPropertyName = "MemberID",
                ReadOnly = true
            };
            returnHistoryDataGridView.Columns.Add(memberIdColumn);

            DataGridViewTextBoxColumn returnDateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Date of Return",
                Name = "ReturnDate",
                DataPropertyName = "ReturnDate",
                ReadOnly = true,
            };
            returnHistoryDataGridView.Columns.Add(returnDateColumn);


            DataGridViewTextBoxColumn returnedItemIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Returned Item ID",
                Name = "ReturnedItemID",
                DataPropertyName = "ReturnedItemID",
                ReadOnly = true
            };
            returnItemsDataGridView.Columns.Add(returnedItemIdColumn);

            DataGridViewTextBoxColumn furnitureIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Furniture ID",
                Name = "FurnitureID",
                DataPropertyName = "FurnitureID",
                ReadOnly = true
            };
            returnItemsDataGridView.Columns.Add(furnitureIdColumn);

            DataGridViewTextBoxColumn furnitureNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Furniture Name",
                Name = "FurnitureName",
                DataPropertyName = "FurnitureName",
                ReadOnly = true
            };
            returnItemsDataGridView.Columns.Add(furnitureNameColumn);

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Description",
                Name = "Description",
                DataPropertyName = "Description",
                ReadOnly = true
            };
            returnItemsDataGridView.Columns.Add(descriptionColumn);

            DataGridViewTextBoxColumn categoryNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Category Name",
                Name = "CategoryName",
                DataPropertyName = "CategoryName",
                ReadOnly = true
            };
            returnItemsDataGridView.Columns.Add(categoryNameColumn);

            DataGridViewTextBoxColumn styleNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Style Name",
                Name = "StyleName",
                DataPropertyName = "StyleName",
                ReadOnly = true
            };
            returnItemsDataGridView.Columns.Add(styleNameColumn);

            DataGridViewTextBoxColumn dailyRateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Daily Rate",
                Name = "DailyRate",
                DataPropertyName = "DailyRate",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                }
            };
            returnItemsDataGridView.Columns.Add(dailyRateColumn);


            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                Name = "Quantity",
                DataPropertyName = "Quantity",
                ReadOnly = true
            };
            returnItemsDataGridView.Columns.Add(quantityColumn);

            DataGridViewTextBoxColumn quantityReturnedColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity Returned",
                Name = "QuantityReturned",
                DataPropertyName = "QuantityReturned",
                ReadOnly = true
            };
            returnItemsDataGridView.Columns.Add(quantityReturnedColumn);


            DataGridViewTextBoxColumn rentalDateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Rental Date",
                Name = "RentalDate",
                DataPropertyName = "RentalDate",
                ReadOnly = true
            };
            returnHistoryDataGridView.Columns.Add(rentalDateColumn);

            DataGridViewTextBoxColumn dueDateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Due Date",
                Name = "DueDate",
                DataPropertyName = "DueDate",
                ReadOnly = true,
            };
            returnHistoryDataGridView.Columns.Add(dueDateColumn);

            DataGridViewTextBoxColumn customerNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Customer Name",
                Name = "CustomerName",
                DataPropertyName = "CustomerName",
                ReadOnly = true
            };
            returnHistoryDataGridView.Columns.Add(customerNameColumn);

            DataGridViewTextBoxColumn employeeNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Employee Name",
                Name = "EmployeeName",
                DataPropertyName = "EmployeeName",
                ReadOnly = true
            };
            returnHistoryDataGridView.Columns.Add(employeeNameColumn);

            returnItemsDataGridView.AutoGenerateColumns = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(customerIDTextBox.Text, out int customerId))
            {
                var returnHistory = returnController.GetReturnTransactionsByMemberID(customerId);

                if (returnHistory != null && returnHistory.Count > 0)
                {
                    returnHistoryDataGridView.DataSource = returnHistory;
                    messageLabel.Text = "";
                }
                else
                {
                    messageLabel.Text = "No return history found";
                    messageLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                messageLabel.Text = "Please enter a valid customer ID";
                messageLabel.ForeColor = Color.Red;
            }
        }

        private void ReturnHistoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dataGridView = sender as DataGridView;
                var selectedRow = dataGridView.Rows[e.RowIndex];
                int returnTransactionID = Convert.ToInt32(selectedRow.Cells["ReturnTransactionID"].Value);

                var returnedItems = returnController.GetReturnedItemsByTransactionId(returnTransactionID);
                returnItemsDataGridView.DataSource = returnedItems;
            }
        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            returnHistoryDataGridView.DataSource = null;
            returnItemsDataGridView.DataSource = null;
            messageLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            returnHistoryDataGridView.DataSource = null;
            returnItemsDataGridView.DataSource = null;
            customerIDTextBox.Text = "";
            messageLabel.Text = "";
        }

        private void ReturnHistoryDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == returnHistoryDataGridView.Columns["ReturnDate"].Index ||
                e.ColumnIndex == returnHistoryDataGridView.Columns["RentalDate"].Index ||
                e.ColumnIndex == returnHistoryDataGridView.Columns["DueDate"].Index)
            {
                if (e.Value != null)
                {
                    DateTime date = (DateTime)e.Value;
                    e.Value = date.ToString("d");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
