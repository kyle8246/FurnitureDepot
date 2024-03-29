using FurnitureDepot.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FurnitureDepot.UserControls
{
    /// <summary>
    /// Rental History User Control Class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class RentalHistoryUserControl : UserControl
    {
        private RentalController rentalController = new RentalController();

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalHistoryUserControl"/> class.
        /// </summary>
        public RentalHistoryUserControl()
        {
            InitializeComponent();
            this.rentalHistoryDataGridView.CellClick += new DataGridViewCellEventHandler(this.RentalHistoryDataGridView_CellClick);

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(customerIDTextBox.Text, out int customerId))
            {
                messageLabel.Text = "";

                var rentalHistory = rentalController.GetRentalTransactionsByMemberID(customerId);

                if (rentalHistory != null && rentalHistory.Count > 0)
                {
                    rentalHistoryDataGridView.DataSource = rentalHistory;
                }
                else
                {
                    messageLabel.Text = "No rental history found";
                    messageLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                messageLabel.Text = "Please enter a valid customer ID";
                messageLabel.ForeColor = Color.Red;
            }
        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            rentalHistoryDataGridView.DataSource = null;
            rentalItemsDataGridView.DataSource = null;
            messageLabel.Text = "";
        }

        private void RentalHistoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dataGridView = sender as DataGridView;
                var selectedRow = dataGridView.Rows[e.RowIndex];
                int rentalTransactionID = Convert.ToInt32(selectedRow.Cells["RentalTransactionID"].Value);
                
                var rentalItems = rentalController.GetRentalItemsByTransactionId(rentalTransactionID);
                rentalItemsDataGridView.DataSource = rentalItems;
            }
        }

    }
}
