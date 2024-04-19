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
                ReadOnly = true
            };
            returnHistoryDataGridView.Columns.Add(returnDateColumn);

            returnHistoryDataGridView.AutoGenerateColumns = false;        
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

        private void ClearButton_Click(object sender, EventArgs e)

        {

            returnHistoryDataGridView.DataSource = null;
            returnItemsDataGridView.DataSource = null;
            customerIDTextBox.Text = "";
            messageLabel.Text = "";
        }
    }
}
