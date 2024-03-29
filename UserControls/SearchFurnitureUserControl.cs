using System;
using System.Drawing;
using System.Windows.Forms;
using FurnitureDepot.DAL;

namespace FurnitureDepot.UserControls
{
    /// <summary>
    /// Serach Furniture User Control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchFurnitureUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFurnitureUserControl"/> class.
        /// </summary>
        public SearchFurnitureUserControl()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            furnitureDataGridView.DataSource = null;
            messageLabel.Text = "";
            messageLabel.ForeColor = SystemColors.ControlText;

            string furnitureID = idTextBox.Text.Trim();
            string category = categoryTextBox.Text.Trim();
            string style = styleTextBox.Text.Trim();

            if (!ValidateSearchCriteria(furnitureID, category, style))
            {
                messageLabel.Text = "Please enter at least one search criteria.";
                messageLabel.ForeColor = Color.Red;
                return;
            }

            if (!string.IsNullOrWhiteSpace(furnitureID) && !int.TryParse(furnitureID, out int _))
            {
                messageLabel.Text = "Enter a valid Furniture ID (numeric only).";
                messageLabel.ForeColor = Color.Red;
                return;
            }

            try
            {
                var furnitureDAL = new FurnitureDAL();
                var furnitureItems = furnitureDAL.SearchFurniture(furnitureID, category, style);
                if (furnitureItems.Count == 0)
                {
                    messageLabel.Text = "No results found.";
                    messageLabel.ForeColor = Color.Red;
                }
                else
                {
                    furnitureDataGridView.DataSource = furnitureItems;

                    if (furnitureDataGridView.Columns["DailyRentalRate"] != null)
                    {
                        furnitureDataGridView.Columns["DailyRentalRate"].DefaultCellStyle.Format = "C2";
                    }
                }
            }
            catch (Exception ex)
            {
                messageLabel.Text = $"An error occurred while searching for furniture: {ex.Message}";
                messageLabel.ForeColor = Color.Red;
            }
        }

        private bool ValidateSearchCriteria(string furnitureID, string category, string style)
        {
            return !string.IsNullOrWhiteSpace(furnitureID) ||
                   !string.IsNullOrWhiteSpace(category) ||
                   !string.IsNullOrWhiteSpace(style);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            idTextBox.Clear();
            categoryTextBox.Clear();
            styleTextBox.Clear();
            furnitureDataGridView.DataSource = null;
            messageLabel.Text = "";
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearResults();
        }

        private void CategoryTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearResults();
        }

        private void StyleTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearResults();
        }

        private void ClearResults()
        {
            furnitureDataGridView.DataSource = null;
            messageLabel.Text = "";
        }
    }
}
