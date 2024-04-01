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
            this.dueDateDatePicker.ValueChanged += new System.EventHandler(this.DueDateDatePicker_ValueChanged);
        }

        private void PopulateFurnitureComboBox()
        {
            List<Furniture> furnitureItems = furnitureController.GetAllFurnitureItems();
            furnitureItems.Insert(0, new Furniture { FurnitureID = 0, Name = " - - Select - - " });

            this.furnitureComboBox.DataSource = furnitureItems;
            this.furnitureComboBox.DisplayMember = "Name";
            this.furnitureComboBox.ValueMember = "FurnitureID";

            this.furnitureComboBox.SelectedIndex = 0;
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
            if (currentOrderCustomer == null)
            {
                this.customerNameLabel.Text = "Please search a customer.";
                this.customerNameLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                if (furnitureComboBox.SelectedIndex > 0)
                {
                    var selectedFurniture = furnitureComboBox.SelectedItem as Furniture;
                    if (selectedFurniture != null)
                    {
                        int quantity = (int)quantityPicker.Value;
                        if (quantity > 0)
                        {
                            bool itemFound = false;
                            foreach (DataGridViewRow row in cartDataGridView.Rows)
                            {
                                if (row.Cells["nameColumn"].Value.ToString() == selectedFurniture.Name)
                                {
                                    int currentQuantity = Convert.ToInt32(row.Cells["quantityColumn"].Value);
                                    row.Cells["quantityColumn"].Value = currentQuantity + quantity;
                                    itemFound = true;
                                    break; 
                                }
                            }

                            if (!itemFound)
                            {
                                int rowIndex = this.cartDataGridView.Rows.Add();
                                DataGridViewRow newRow = cartDataGridView.Rows[rowIndex];
                                newRow.Cells["nameColumn"].Value = selectedFurniture.Name;
                                newRow.Cells["unitPriceColumn"].Value = selectedFurniture.DailyRentalRate;
                                newRow.Cells["quantityColumn"].Value = quantity;
                            }

                            this.quantityPicker.Value = 1;
                            this.furnitureComboBox.SelectedIndex = 0;
                            UpdateTotalCost();
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a furniture item.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (currentOrderCustomer == null)
            {
                this.customerNameLabel.Text = "Please search a customer.";
                this.customerNameLabel.ForeColor = Color.Red;
                return;
            }
            else if (this.cartDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No items in cart to remove.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.furnitureComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a furniture item.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedFurniture = furnitureComboBox.SelectedItem as Furniture;
            if (selectedFurniture != null)
            {
                bool itemFound = false;
                foreach (DataGridViewRow row in this.cartDataGridView.Rows)
                {
                    if (row.Cells["nameColumn"].Value.ToString() == selectedFurniture.Name)
                    {
                        itemFound = true;
                        int currentQuantity = Convert.ToInt32(row.Cells["quantityColumn"].Value);
                        int decrementValue = (int)this.quantityPicker.Value;

                        if (decrementValue > currentQuantity)
                        {
                            MessageBox.Show("Cannot remove more items than are in the cart.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (decrementValue == currentQuantity)
                        {
                            this.cartDataGridView.Rows.Remove(row);
                            this.quantityPicker.Value = 1;
                            this.furnitureComboBox.SelectedIndex = 0;
                            UpdateTotalCost();
                        }
                        else
                        {
                            row.Cells["quantityColumn"].Value = currentQuantity - decrementValue;
                            this.quantityPicker.Value = 1;
                            this.furnitureComboBox.SelectedIndex = 0;
                            UpdateTotalCost();
                        }
                        break;
                    }
                }

                if (!itemFound)
                {
                    MessageBox.Show("The selected item is not in the cart.", "Item Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
            this.customerIDTextBox.Text = string.Empty;
        }

        private void RentalTransactionUserControl_Load(object sender, EventArgs e)
        {
            PopulateFurnitureComboBox();
            InitializeCartGridView();
            this.currentOrderCustomer = null;
            this.customerNameLabel.Text = "Please search a customer.";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
            this.customerIDTextBox.Text = string.Empty;
        }

        private void InitializeCartGridView()
        {
            this.cartDataGridView.Columns.Clear();

            this.cartDataGridView.Columns.Add("nameColumn", "Item Name");
            this.cartDataGridView.Columns.Add("quantityColumn", "Quantity");
            this.cartDataGridView.Columns.Add("unitPriceColumn", "Unit Price");

            this.cartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void customerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            this.currentOrderCustomer = null;
            this.cartDataGridView.Rows.Clear();

            this.customerNameLabel.ForeColor = Color.Black;
            this.customerNameLabel.Text = "Please search a customer.";
            this.totalCostLabel.Text = "Total Cost: ";
            this.dueDateDatePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// Clears the member identifier.
        /// </summary>
        public void ClearMemberID()
        {
            this.customerIDTextBox.Text = string.Empty;
        }

        private void DueDateDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void UpdateTotalCost()
        {
            decimal totalCost = 0;
            TimeSpan rentalDuration = dueDateDatePicker.Value.Date - DateTime.Now.Date;
            int rentalDays = Math.Max(1, rentalDuration.Days);

            foreach (DataGridViewRow row in cartDataGridView.Rows)
            {
                if (row.Cells["unitPriceColumn"].Value != null && row.Cells["quantityColumn"].Value != null)
                {
                    decimal dailyRate = Convert.ToDecimal(row.Cells["unitPriceColumn"].Value);
                    int quantity = Convert.ToInt32(row.Cells["quantityColumn"].Value);
                    totalCost += dailyRate * quantity * rentalDays;
                }
            }

            totalCostLabel.Text = $"Total Cost: {totalCost:C}";
        }

    }
}
