using System;
using System.Drawing;
using System.Windows.Forms;
using FurnitureDepot.Controller;
using FurnitureDepot.DAL;

namespace FurnitureDepot.UserControls
{
    /// <summary>
    /// Serach Furniture User Control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchFurnitureUserControl : UserControl
    {

        private readonly FurnitureController furnitureController;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFurnitureUserControl"/> class.
        /// </summary>
        public SearchFurnitureUserControl()
        {
            InitializeComponent();
            furnitureController = new FurnitureController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            furnitureDataGridView.DataSource = null;
            messageLabel.Text = "";
            messageLabel.ForeColor = SystemColors.ControlText;

            string furnitureID = idTextBox.Text.Trim();

            string category = categoryComboBox.SelectedItem?.ToString() ?? "";
            string style = styleComboBox.SelectedItem?.ToString() ?? "";

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
                var furnitureItems = furnitureController.SearchFurniture(furnitureID, category, style);

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
            categoryComboBox.SelectedIndex = -1;
            styleComboBox.SelectedIndex = -1;
            furnitureDataGridView.DataSource = null;
            messageLabel.Text = "";
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            idTextBox.Clear();
            categoryComboBox.SelectedIndex = -1;
            styleComboBox.SelectedIndex = -1;
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

        private void PopulateComboBoxes()
        {
            PopulateCategories();
            PopulateStyles();
        }

        private void PopulateCategories()
        {
            var categories = furnitureController.GetFurnitureCategories();
            categoryComboBox.DataSource = categories;
            categoryComboBox.SelectedIndex = -1;
        }

        private void PopulateStyles()
        {
            var styles = furnitureController.GetFurnitureStyles();
            styleComboBox.DataSource = styles;
            styleComboBox.SelectedIndex = -1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PopulateComboBoxes();
        }
    }
}
