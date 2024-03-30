using FurnitureDepot.Controller;
using FurnitureDepot.Model;
using System;
using System.Collections.Generic;
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

        public RentalTransactionUserControl()
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
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
    }
}
