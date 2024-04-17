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
using System.Linq;

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
        private RentalController rentalController;
        private EmployeeController employeeController;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalTransactionUserControl"/> class.
        /// </summary>
        public RentalTransactionUserControl()
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.customerController = new CustomerController();
            this.rentalController = new RentalController();
            this.currentOrderCustomer = new Customer();
            this.employeeController = new EmployeeController();
            this.dueDateDatePicker.ValueChanged += new System.EventHandler(this.DueDateDatePicker_ValueChanged);
        }

        private void PopulateFurnitureCategoryComboBox()
        {
            List<String> furnitureCategories = furnitureController.GetFurnitureCategories();
            furnitureCategories.Insert(0, "- - Select Category - -");

            this.categoryComboBox.DataSource = furnitureCategories;
            this.categoryComboBox.SelectedIndex = 0;
        }

        private void PopulateFurnitureStyleComboBox()
        {
            List<String> furnitureStyles = furnitureController.GetFurnitureStyles();
            furnitureStyles.Insert(0, "- - Select Style - -");

            this.styleComboBox.DataSource = furnitureStyles;
            this.styleComboBox.SelectedIndex = 0;
        }

        private void UpdateFurnitureItemsComboBox()
        {
            string selectedCategory = categoryComboBox.SelectedIndex > 0 ? categoryComboBox.SelectedValue.ToString() : null;
            string selectedStyle = styleComboBox.SelectedIndex > 0 ? styleComboBox.SelectedValue.ToString() : null;

            var furnitureItems = furnitureController.SearchFurnitureByCategoryAndStyleOnly(selectedCategory, selectedStyle);

            furnitureItemComboBox.DataSource = null;
            furnitureItemComboBox.Items.Clear();
            furnitureItemComboBox.Items.Add("- - Select Item - -");
            
            foreach (var item in furnitureItems)
            {
                furnitureItemComboBox.Items.Add(item);
            }

            furnitureItemComboBox.DisplayMember = "Name";
            furnitureItemComboBox.ValueMember = "FurnitureID";
            furnitureItemComboBox.SelectedIndex = 0;
        }

        private void SearchButton_Click(object sender, EventArgs e)
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

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (currentOrderCustomer == null)
            {
                this.customerNameLabel.Text = "Please search a customer.";
                this.customerNameLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                if (furnitureItemComboBox.SelectedIndex > 0)
                {
                    var selectedFurniture = furnitureItemComboBox.SelectedItem as Furniture;
                    if (selectedFurniture != null)
                    {
                        int quantityToAdd = (int)quantityPicker.Value;
                        if (quantityToAdd > 0)
                        {
                            int currentQuantityInCart = GetQuantityFromCart(selectedFurniture.Name);

                            if (!furnitureController.CheckInStock(selectedFurniture.FurnitureID, currentQuantityInCart + quantityToAdd))
                            {
                                MessageBox.Show("The required quantity is not available in stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            bool itemFound = false;
                            foreach (DataGridViewRow row in cartDataGridView.Rows)
                            {
                                if ((int)row.Cells["furnitureIdColumn"].Value == selectedFurniture.FurnitureID)
                                {
                                    int currentQuantity = Convert.ToInt32(row.Cells["quantityColumn"].Value);
                                    row.Cells["quantityColumn"].Value = currentQuantity + quantityToAdd;
                                    itemFound = true;
                                    ResetFurnitureComboBoxes();
                                    break;
                                }
                            }

                            if (!itemFound)
                            {
                                int rowIndex = this.cartDataGridView.Rows.Add();
                                DataGridViewRow newRow = cartDataGridView.Rows[rowIndex];
                                newRow.Cells["nameColumn"].Value = selectedFurniture.Name;
                                newRow.Cells["unitPriceColumn"].Value = selectedFurniture.DailyRentalRate;
                                newRow.Cells["quantityColumn"].Value = quantityToAdd;
                                newRow.Cells["furnitureIdColumn"].Value = selectedFurniture.FurnitureID;
                                ResetFurnitureComboBoxes();
                            }

                            this.quantityPicker.Value = 1;
                            ResetFurnitureComboBoxes();
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

        private int GetQuantityFromCart(string furnitureName)
        {
            int totalQuantity = 0;
            foreach (DataGridViewRow row in this.cartDataGridView.Rows)
            {
                if (row.Cells["nameColumn"].Value.ToString() == furnitureName)
                {
                    totalQuantity += Convert.ToInt32(row.Cells["quantityColumn"].Value);
                }
            }
            return totalQuantity;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
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
            else if (this.furnitureItemComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a furniture item from the drop-down list that is in your cart.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedFurniture = furnitureItemComboBox.SelectedItem as Furniture;
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
                            this.furnitureItemComboBox.SelectedIndex = 0;
                            UpdateTotalCost();
                        }
                        else
                        {
                            row.Cells["quantityColumn"].Value = currentQuantity - decrementValue;
                            this.quantityPicker.Value = 1;
                            this.furnitureItemComboBox.SelectedIndex = 0;
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateRentalTransaction())
            {
                if (ConfirmSubmission())
                {
                    int transactionId = SaveRentalTransaction();
                    DisplayReceipt(transactionId);
                }
            }
        }


        private bool ValidateRentalTransaction()
        {
            if (currentOrderCustomer == null || currentOrderCustomer.MemberID <= 0)
            {
                MessageBox.Show("Please select a customer before submitting the transaction.", "Customer Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cartDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("There are no items in the cart. Please add items before submitting the transaction.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dueDateDatePicker.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("The due date must be in the future. Please select a valid due date.", "Invalid Due Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ConfirmSubmission()
        {
            decimal totalCost = CalculateTotalCost();
            string message = $"The total cost of this transaction is {totalCost:C}. Would you like to proceed?";

            var result = MessageBox.Show(message, "Confirm Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }


        private decimal CalculateTotalCost()
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

            return totalCost;
        }

        private int SaveRentalTransaction()
        {
            int transactionId = -1;

            using (SqlConnection connection = FurnitureDepotDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        RentalTransaction rentalTransaction = new RentalTransaction()
                        {
                            MemberID = currentOrderCustomer.MemberID,
                            EmployeeID = SessionManager.CurrentEmployeeID,
                            RentalDate = DateTime.Now,
                            DueDate = dueDateDatePicker.Value.Date,
                            TotalCost = CalculateTotalCost()
                        };

                        transactionId = rentalController.InsertRentalTransaction(rentalTransaction, transaction);

                        if (transactionId > 0)
                        {
                            List<RentalItem> items = new List<RentalItem>();
                            foreach (DataGridViewRow row in cartDataGridView.Rows)
                            {
                                int furnitureId = Convert.ToInt32(row.Cells["furnitureIdColumn"].Value);
                                int quantity = Convert.ToInt32(row.Cells["quantityColumn"].Value);

                                bool updateSuccess = furnitureController.UpdateInStockNumber(furnitureId, quantity, transaction);

                                if (!updateSuccess)
                                {
                                    MessageBox.Show($"Failed to update inventory for furniture ID {furnitureId}.", "Inventory Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    transaction.Rollback();
                                    return -1;
                                }

                                items.Add(new RentalItem()
                                {
                                    RentalTransactionID = transactionId,
                                    FurnitureID = furnitureId,
                                    Quantity = quantity,
                                    DailyRate = Convert.ToDecimal(row.Cells["unitPriceColumn"].Value)
                                });
                            }

                            rentalController.InsertRentalItems(items, transaction);

                            transaction.Commit();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save the rental transaction.", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return -1;
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred: {ex.Message}", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }

            ClearTransaction();
            return transactionId;
        }


        private void DisplayReceipt(int transactionId)
        {
            RentalTransaction transaction = rentalController.GetRentalTransactionById(transactionId);
            List<RentalItem> items = rentalController.GetRentalItemsByTransactionId(transactionId);

            string customerName = customerController.GetCustomerFullNameById(transaction.MemberID);
            string employeeName = employeeController.GetEmployeeFullNameById(transaction.EmployeeID);

            if (transaction == null || items == null || customerName == null || employeeName == null)
            {
                MessageBox.Show("Error retrieving transaction data.", "Receipt Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder receiptText = new StringBuilder();
            receiptText.AppendLine("Rental Transaction Receipt");
            receiptText.AppendLine("--------------------------");
            receiptText.AppendLine($"Transaction ID: {transaction.RentalTransactionID}");
            receiptText.AppendLine($"Customer ID: {transaction.MemberID} - {customerName}");
            receiptText.AppendLine($"Employee ID: {transaction.EmployeeID} - {employeeName}");
            receiptText.AppendLine($"Rental Date: {transaction.RentalDate.ToShortDateString()}");
            receiptText.AppendLine($"Due Date: {transaction.DueDate:d}");
            receiptText.AppendLine($"Total Cost: {transaction.TotalCost:C}");
            receiptText.AppendLine("\nItems Rented:");

            foreach (var item in items)
            {
                receiptText.AppendLine($"ID: {item.FurnitureID} - {item.FurnitureName} x{item.Quantity} - {item.DailyRate:C} per day");
            }

            MessageBox.Show(receiptText.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.customerIDTextBox.Text = string.Empty;
        }


        private void ClearTransaction()
        {
            cartDataGridView.Rows.Clear();
            furnitureItemComboBox.SelectedIndex = 0;
            totalCostLabel.Text = "Total Cost: $0.00";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Clear();
            this.customerIDTextBox.Text = string.Empty;
            this.categoryComboBox.SelectedIndex = 0;
            this.styleComboBox.SelectedIndex = 0;
            this.furnitureItemComboBox.SelectedIndex = 0;
        }

        private void RentalTransactionUserControl_Load(object sender, EventArgs e)
        {
            PopulateFurnitureCategoryComboBox();
            PopulateFurnitureStyleComboBox();
            UpdateFurnitureItemsComboBox();
            InitializeCartGridView();
            this.currentOrderCustomer = null;
            this.customerNameLabel.Text = "Please search a customer.";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            this.customerIDTextBox.Text = string.Empty;
            this.categoryComboBox.SelectedIndex = 0;
            this.styleComboBox.SelectedIndex = 0;
            this.furnitureItemComboBox.SelectedIndex = 0;
        }

        private void InitializeCartGridView()
        {
            this.cartDataGridView.Columns.Clear();

            this.cartDataGridView.Columns.Add("nameColumn", "Item Name");
            this.cartDataGridView.Columns.Add("quantityColumn", "Quantity");
            this.cartDataGridView.Columns.Add("unitPriceColumn", "Daily Rate");

            var furnitureIdColumn = new DataGridViewTextBoxColumn();
            furnitureIdColumn.Name = "furnitureIdColumn";
            furnitureIdColumn.Visible = false;
            this.cartDataGridView.Columns.Add(furnitureIdColumn);

            this.cartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
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

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFurnitureItemsComboBox();
        }

        private void StyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFurnitureItemsComboBox();
        }

        private void ResetFurnitureComboBoxes()
        {
            this.categoryComboBox.SelectedIndex = 0;
            this.styleComboBox.SelectedIndex = 0;
            this.furnitureItemComboBox.SelectedIndex = 0;
        }

        private void FurnitureItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (furnitureItemComboBox.SelectedIndex > 0)
            {
                var selectedFurniture = furnitureItemComboBox.SelectedItem as Furniture;
                if (selectedFurniture != null)
                {
                    int inStockAdjusted = CalculateInStock(selectedFurniture);
                    inStockTextBox.Text = inStockAdjusted.ToString();
                }
                else
                {
                    inStockTextBox.Text = "N/A";
                }
            }
            else
            {
                inStockTextBox.Clear();
            }
        }

        private int CalculateInStock(Furniture selectedFurniture)
        {
            int inCartQuantity = GetQuantityFromCart(selectedFurniture.Name);
            int inStockNumber = selectedFurniture.InStockNumber ?? 0;
            return inStockNumber - inCartQuantity;
        }

        private void CartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = cartDataGridView.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    var itemName = selectedRow.Cells["nameColumn"].Value.ToString();

                    foreach (var item in furnitureItemComboBox.Items)
                    {
                        if (item is Furniture furniture && furniture.Name == itemName)
                        {
                            furnitureItemComboBox.SelectedItem = furniture;
                            break;
                        }
                    }
                }
            }
        }

    }
}
