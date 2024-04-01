namespace FurnitureDepot.UserControls
{
    partial class RentalTransactionUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rentalTransactionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lowerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lowerLeftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.dueDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.lowerRightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.upperTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.upperLeftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.customerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.furnitureFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.furnitureComboBox = new System.Windows.Forms.ComboBox();
            this.quantityPicker = new System.Windows.Forms.NumericUpDown();
            this.furnitureLabel = new System.Windows.Forms.Label();
            this.upperRightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.addRemoveButtonLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.rentalTransactionTableLayout.SuspendLayout();
            this.lowerTableLayoutPanel.SuspendLayout();
            this.lowerLeftLayoutPanel.SuspendLayout();
            this.lowerRightLayoutPanel.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.upperTableLayoutPanel.SuspendLayout();
            this.upperLeftLayoutPanel.SuspendLayout();
            this.customerFlowLayoutPanel.SuspendLayout();
            this.furnitureFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPicker)).BeginInit();
            this.upperRightLayoutPanel.SuspendLayout();
            this.addRemoveButtonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentalTransactionTableLayout
            // 
            this.rentalTransactionTableLayout.ColumnCount = 2;
            this.rentalTransactionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.087248F));
            this.rentalTransactionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.91275F));
            this.rentalTransactionTableLayout.Controls.Add(this.lowerTableLayoutPanel, 1, 1);
            this.rentalTransactionTableLayout.Controls.Add(this.mainTableLayoutPanel, 1, 0);
            this.rentalTransactionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTransactionTableLayout.Location = new System.Drawing.Point(0, 0);
            this.rentalTransactionTableLayout.Margin = new System.Windows.Forms.Padding(4);
            this.rentalTransactionTableLayout.Name = "rentalTransactionTableLayout";
            this.rentalTransactionTableLayout.RowCount = 2;
            this.rentalTransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.24934F));
            this.rentalTransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.75066F));
            this.rentalTransactionTableLayout.Size = new System.Drawing.Size(993, 464);
            this.rentalTransactionTableLayout.TabIndex = 0;
            // 
            // lowerTableLayoutPanel
            // 
            this.lowerTableLayoutPanel.ColumnCount = 2;
            this.lowerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.43017F));
            this.lowerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.56983F));
            this.lowerTableLayoutPanel.Controls.Add(this.lowerLeftLayoutPanel, 0, 0);
            this.lowerTableLayoutPanel.Controls.Add(this.lowerRightLayoutPanel, 1, 0);
            this.lowerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerTableLayoutPanel.Location = new System.Drawing.Point(34, 367);
            this.lowerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.lowerTableLayoutPanel.Name = "lowerTableLayoutPanel";
            this.lowerTableLayoutPanel.RowCount = 2;
            this.lowerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.8421F));
            this.lowerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.lowerTableLayoutPanel.Size = new System.Drawing.Size(955, 93);
            this.lowerTableLayoutPanel.TabIndex = 1;
            // 
            // lowerLeftLayoutPanel
            // 
            this.lowerLeftLayoutPanel.ColumnCount = 3;
            this.lowerLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.94444F));
            this.lowerLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.05556F));
            this.lowerLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.lowerLeftLayoutPanel.Controls.Add(this.dueDateLabel, 0, 0);
            this.lowerLeftLayoutPanel.Controls.Add(this.dueDateDatePicker, 1, 0);
            this.lowerLeftLayoutPanel.Controls.Add(this.totalCostLabel, 1, 1);
            this.lowerLeftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerLeftLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.lowerLeftLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.lowerLeftLayoutPanel.Name = "lowerLeftLayoutPanel";
            this.lowerLeftLayoutPanel.RowCount = 2;
            this.lowerLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.33333F));
            this.lowerLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.66667F));
            this.lowerLeftLayoutPanel.Size = new System.Drawing.Size(588, 72);
            this.lowerLeftLayoutPanel.TabIndex = 0;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(35, 15);
            this.dueDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(67, 16);
            this.dueDateLabel.TabIndex = 0;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // dueDateDatePicker
            // 
            this.dueDateDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dueDateDatePicker.Location = new System.Drawing.Point(110, 4);
            this.dueDateDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dueDateDatePicker.Name = "dueDateDatePicker";
            this.dueDateDatePicker.Size = new System.Drawing.Size(281, 22);
            this.dueDateDatePicker.TabIndex = 1;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(110, 41);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(85, 20);
            this.totalCostLabel.TabIndex = 2;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // lowerRightLayoutPanel
            // 
            this.lowerRightLayoutPanel.ColumnCount = 2;
            this.lowerRightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lowerRightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lowerRightLayoutPanel.Controls.Add(this.submitButton, 0, 0);
            this.lowerRightLayoutPanel.Controls.Add(this.cancelButton, 1, 0);
            this.lowerRightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerRightLayoutPanel.Location = new System.Drawing.Point(600, 4);
            this.lowerRightLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.lowerRightLayoutPanel.Name = "lowerRightLayoutPanel";
            this.lowerRightLayoutPanel.RowCount = 2;
            this.lowerRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.lowerRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.lowerRightLayoutPanel.Size = new System.Drawing.Size(351, 72);
            this.lowerRightLayoutPanel.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButton.Location = new System.Drawing.Point(4, 4);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(167, 31);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit Transaction";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(179, 4);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(168, 31);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.cartDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.upperTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(34, 4);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.60294F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.39706F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(955, 355);
            this.mainTableLayoutPanel.TabIndex = 2;
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartDataGridView.Location = new System.Drawing.Point(4, 141);
            this.cartDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.Size = new System.Drawing.Size(947, 210);
            this.cartDataGridView.TabIndex = 0;
            // 
            // upperTableLayoutPanel
            // 
            this.upperTableLayoutPanel.ColumnCount = 2;
            this.upperTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.15493F));
            this.upperTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.84507F));
            this.upperTableLayoutPanel.Controls.Add(this.upperLeftLayoutPanel, 0, 0);
            this.upperTableLayoutPanel.Controls.Add(this.upperRightLayoutPanel, 1, 0);
            this.upperTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.upperTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.upperTableLayoutPanel.Name = "upperTableLayoutPanel";
            this.upperTableLayoutPanel.RowCount = 2;
            this.upperTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.upperTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.upperTableLayoutPanel.Size = new System.Drawing.Size(947, 129);
            this.upperTableLayoutPanel.TabIndex = 1;
            // 
            // upperLeftLayoutPanel
            // 
            this.upperLeftLayoutPanel.ColumnCount = 2;
            this.upperLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.53623F));
            this.upperLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.46377F));
            this.upperLeftLayoutPanel.Controls.Add(this.customerIDLabel, 0, 0);
            this.upperLeftLayoutPanel.Controls.Add(this.customerFlowLayoutPanel, 1, 0);
            this.upperLeftLayoutPanel.Controls.Add(this.furnitureFlowLayoutPanel, 1, 1);
            this.upperLeftLayoutPanel.Controls.Add(this.furnitureLabel, 0, 1);
            this.upperLeftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperLeftLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.upperLeftLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.upperLeftLayoutPanel.Name = "upperLeftLayoutPanel";
            this.upperLeftLayoutPanel.RowCount = 2;
            this.upperLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.38272F));
            this.upperLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.61728F));
            this.upperLeftLayoutPanel.Size = new System.Drawing.Size(552, 103);
            this.upperLeftLayoutPanel.TabIndex = 0;
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(24, 15);
            this.customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(103, 20);
            this.customerIDLabel.TabIndex = 0;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // customerFlowLayoutPanel
            // 
            this.customerFlowLayoutPanel.Controls.Add(this.customerIDTextBox);
            this.customerFlowLayoutPanel.Controls.Add(this.searchButton);
            this.customerFlowLayoutPanel.Controls.Add(this.clearButton);
            this.customerFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerFlowLayoutPanel.Location = new System.Drawing.Point(155, 4);
            this.customerFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.customerFlowLayoutPanel.Name = "customerFlowLayoutPanel";
            this.customerFlowLayoutPanel.Size = new System.Drawing.Size(393, 42);
            this.customerFlowLayoutPanel.TabIndex = 2;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customerIDTextBox.Location = new System.Drawing.Point(4, 10);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(167, 22);
            this.customerIDTextBox.TabIndex = 0;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.customerIDTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(179, 4);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 28);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(292, 4);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(83, 28);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // furnitureFlowLayoutPanel
            // 
            this.furnitureFlowLayoutPanel.Controls.Add(this.furnitureComboBox);
            this.furnitureFlowLayoutPanel.Controls.Add(this.quantityPicker);
            this.furnitureFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureFlowLayoutPanel.Location = new System.Drawing.Point(155, 54);
            this.furnitureFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.furnitureFlowLayoutPanel.Name = "furnitureFlowLayoutPanel";
            this.furnitureFlowLayoutPanel.Size = new System.Drawing.Size(393, 45);
            this.furnitureFlowLayoutPanel.TabIndex = 3;
            // 
            // furnitureComboBox
            // 
            this.furnitureComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.furnitureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.furnitureComboBox.FormattingEnabled = true;
            this.furnitureComboBox.Location = new System.Drawing.Point(4, 4);
            this.furnitureComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.furnitureComboBox.Name = "furnitureComboBox";
            this.furnitureComboBox.Size = new System.Drawing.Size(296, 24);
            this.furnitureComboBox.TabIndex = 0;
            // 
            // quantityPicker
            // 
            this.quantityPicker.Location = new System.Drawing.Point(308, 4);
            this.quantityPicker.Margin = new System.Windows.Forms.Padding(4);
            this.quantityPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityPicker.Name = "quantityPicker";
            this.quantityPicker.Size = new System.Drawing.Size(75, 22);
            this.quantityPicker.TabIndex = 1;
            this.quantityPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // furnitureLabel
            // 
            this.furnitureLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.furnitureLabel.AutoSize = true;
            this.furnitureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureLabel.Location = new System.Drawing.Point(70, 66);
            this.furnitureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.furnitureLabel.Name = "furnitureLabel";
            this.furnitureLabel.Size = new System.Drawing.Size(77, 20);
            this.furnitureLabel.TabIndex = 1;
            this.furnitureLabel.Text = "Furniture:";
            // 
            // upperRightLayoutPanel
            // 
            this.upperRightLayoutPanel.ColumnCount = 1;
            this.upperRightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.upperRightLayoutPanel.Controls.Add(this.customerNameLabel, 0, 0);
            this.upperRightLayoutPanel.Controls.Add(this.addRemoveButtonLayoutPanel, 0, 1);
            this.upperRightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperRightLayoutPanel.Location = new System.Drawing.Point(564, 4);
            this.upperRightLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.upperRightLayoutPanel.Name = "upperRightLayoutPanel";
            this.upperRightLayoutPanel.RowCount = 2;
            this.upperRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.upperRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.upperRightLayoutPanel.Size = new System.Drawing.Size(379, 103);
            this.upperRightLayoutPanel.TabIndex = 1;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(4, 0);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(132, 20);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name: ";
            // 
            // addRemoveButtonLayoutPanel
            // 
            this.addRemoveButtonLayoutPanel.Controls.Add(this.addItemButton);
            this.addRemoveButtonLayoutPanel.Controls.Add(this.removeItemButton);
            this.addRemoveButtonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRemoveButtonLayoutPanel.Location = new System.Drawing.Point(4, 55);
            this.addRemoveButtonLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.addRemoveButtonLayoutPanel.Name = "addRemoveButtonLayoutPanel";
            this.addRemoveButtonLayoutPanel.Size = new System.Drawing.Size(371, 44);
            this.addRemoveButtonLayoutPanel.TabIndex = 1;
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addItemButton.Location = new System.Drawing.Point(4, 4);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(157, 39);
            this.addItemButton.TabIndex = 0;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemButton.Location = new System.Drawing.Point(169, 4);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(155, 39);
            this.removeItemButton.TabIndex = 1;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // RentalTransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rentalTransactionTableLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentalTransactionUserControl";
            this.Size = new System.Drawing.Size(993, 464);
            this.Load += new System.EventHandler(this.RentalTransactionUserControl_Load);
            this.rentalTransactionTableLayout.ResumeLayout(false);
            this.lowerTableLayoutPanel.ResumeLayout(false);
            this.lowerLeftLayoutPanel.ResumeLayout(false);
            this.lowerLeftLayoutPanel.PerformLayout();
            this.lowerRightLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.upperTableLayoutPanel.ResumeLayout(false);
            this.upperLeftLayoutPanel.ResumeLayout(false);
            this.upperLeftLayoutPanel.PerformLayout();
            this.customerFlowLayoutPanel.ResumeLayout(false);
            this.customerFlowLayoutPanel.PerformLayout();
            this.furnitureFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityPicker)).EndInit();
            this.upperRightLayoutPanel.ResumeLayout(false);
            this.upperRightLayoutPanel.PerformLayout();
            this.addRemoveButtonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rentalTransactionTableLayout;
        private System.Windows.Forms.TableLayoutPanel lowerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.TableLayoutPanel upperTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel upperLeftLayoutPanel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label furnitureLabel;
        private System.Windows.Forms.TableLayoutPanel upperRightLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel customerFlowLayoutPanel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.FlowLayoutPanel furnitureFlowLayoutPanel;
        private System.Windows.Forms.ComboBox furnitureComboBox;
        private System.Windows.Forms.NumericUpDown quantityPicker;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.FlowLayoutPanel addRemoveButtonLayoutPanel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.TableLayoutPanel lowerLeftLayoutPanel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.DateTimePicker dueDateDatePicker;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TableLayoutPanel lowerRightLayoutPanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
    }
}
