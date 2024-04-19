namespace FurnitureDepot.UserControls
{
    partial class ReturnManagementUserControl
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.upperRightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.customerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.rentalTransactionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lowerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lowerLeftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.feesLabel = new System.Windows.Forms.Label();
            this.feesValueLabel = new System.Windows.Forms.Label();
            this.lowerRightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.processReturnButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.returnTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.selectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.transactionIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentedQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnQuantityColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.upperTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.upperLeftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.upperRightLayoutPanel.SuspendLayout();
            this.customerFlowLayoutPanel.SuspendLayout();
            this.rentalTransactionTableLayout.SuspendLayout();
            this.lowerTableLayoutPanel.SuspendLayout();
            this.lowerLeftLayoutPanel.SuspendLayout();
            this.lowerRightLayoutPanel.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionDataGridView)).BeginInit();
            this.upperTableLayoutPanel.SuspendLayout();
            this.upperLeftLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(3, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(132, 20);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name: ";
            // 
            // upperRightLayoutPanel
            // 
            this.upperRightLayoutPanel.ColumnCount = 1;
            this.upperRightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.upperRightLayoutPanel.Controls.Add(this.customerNameLabel, 0, 0);
            this.upperRightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperRightLayoutPanel.Location = new System.Drawing.Point(431, 3);
            this.upperRightLayoutPanel.Name = "upperRightLayoutPanel";
            this.upperRightLayoutPanel.RowCount = 2;
            this.upperRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.upperRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.upperRightLayoutPanel.Size = new System.Drawing.Size(290, 44);
            this.upperRightLayoutPanel.TabIndex = 1;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customerIDTextBox.Location = new System.Drawing.Point(3, 6);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(126, 20);
            this.customerIDTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(135, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(79, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(220, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(62, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // customerFlowLayoutPanel
            // 
            this.customerFlowLayoutPanel.Controls.Add(this.customerIDTextBox);
            this.customerFlowLayoutPanel.Controls.Add(this.searchButton);
            this.customerFlowLayoutPanel.Controls.Add(this.clearButton);
            this.customerFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerFlowLayoutPanel.Location = new System.Drawing.Point(119, 3);
            this.customerFlowLayoutPanel.Name = "customerFlowLayoutPanel";
            this.customerFlowLayoutPanel.Size = new System.Drawing.Size(300, 29);
            this.customerFlowLayoutPanel.TabIndex = 2;
            // 
            // rentalTransactionTableLayout
            // 
            this.rentalTransactionTableLayout.ColumnCount = 2;
            this.rentalTransactionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.208054F));
            this.rentalTransactionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.79195F));
            this.rentalTransactionTableLayout.Controls.Add(this.lowerTableLayoutPanel, 1, 1);
            this.rentalTransactionTableLayout.Controls.Add(this.mainTableLayoutPanel, 1, 0);
            this.rentalTransactionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTransactionTableLayout.Location = new System.Drawing.Point(0, 0);
            this.rentalTransactionTableLayout.Name = "rentalTransactionTableLayout";
            this.rentalTransactionTableLayout.RowCount = 2;
            this.rentalTransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.24934F));
            this.rentalTransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.75066F));
            this.rentalTransactionTableLayout.Size = new System.Drawing.Size(745, 377);
            this.rentalTransactionTableLayout.TabIndex = 1;
            // 
            // lowerTableLayoutPanel
            // 
            this.lowerTableLayoutPanel.ColumnCount = 2;
            this.lowerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.43017F));
            this.lowerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.56983F));
            this.lowerTableLayoutPanel.Controls.Add(this.lowerLeftLayoutPanel, 0, 0);
            this.lowerTableLayoutPanel.Controls.Add(this.lowerRightLayoutPanel, 1, 0);
            this.lowerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerTableLayoutPanel.Location = new System.Drawing.Point(12, 298);
            this.lowerTableLayoutPanel.Name = "lowerTableLayoutPanel";
            this.lowerTableLayoutPanel.RowCount = 2;
            this.lowerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.8421F));
            this.lowerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.lowerTableLayoutPanel.Size = new System.Drawing.Size(730, 76);
            this.lowerTableLayoutPanel.TabIndex = 1;
            // 
            // lowerLeftLayoutPanel
            // 
            this.lowerLeftLayoutPanel.ColumnCount = 3;
            this.lowerLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.94444F));
            this.lowerLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.05556F));
            this.lowerLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.lowerLeftLayoutPanel.Controls.Add(this.feesLabel, 0, 0);
            this.lowerLeftLayoutPanel.Controls.Add(this.feesValueLabel, 1, 0);
            this.lowerLeftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerLeftLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.lowerLeftLayoutPanel.Name = "lowerLeftLayoutPanel";
            this.lowerLeftLayoutPanel.RowCount = 2;
            this.lowerLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.33333F));
            this.lowerLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.66667F));
            this.lowerLeftLayoutPanel.Size = new System.Drawing.Size(449, 60);
            this.lowerLeftLayoutPanel.TabIndex = 0;
            // 
            // feesLabel
            // 
            this.feesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.feesLabel.AutoSize = true;
            this.feesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesLabel.Location = new System.Drawing.Point(8, 0);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(68, 25);
            this.feesLabel.TabIndex = 0;
            this.feesLabel.Text = "Fees/Fines:";
            // 
            // feesValueLabel
            // 
            this.feesValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.feesValueLabel.AutoSize = true;
            this.feesValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesValueLabel.Location = new System.Drawing.Point(82, 9);
            this.feesValueLabel.Name = "feesValueLabel";
            this.feesValueLabel.Size = new System.Drawing.Size(0, 16);
            this.feesValueLabel.TabIndex = 1;
            // 
            // lowerRightLayoutPanel
            // 
            this.lowerRightLayoutPanel.ColumnCount = 2;
            this.lowerRightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lowerRightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lowerRightLayoutPanel.Controls.Add(this.processReturnButton, 0, 0);
            this.lowerRightLayoutPanel.Controls.Add(this.cancelButton, 1, 0);
            this.lowerRightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerRightLayoutPanel.Location = new System.Drawing.Point(458, 3);
            this.lowerRightLayoutPanel.Name = "lowerRightLayoutPanel";
            this.lowerRightLayoutPanel.RowCount = 2;
            this.lowerRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.lowerRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.lowerRightLayoutPanel.Size = new System.Drawing.Size(269, 60);
            this.lowerRightLayoutPanel.TabIndex = 1;
            // 
            // processReturnButton
            // 
            this.processReturnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processReturnButton.Location = new System.Drawing.Point(3, 3);
            this.processReturnButton.Name = "processReturnButton";
            this.processReturnButton.Size = new System.Drawing.Size(128, 27);
            this.processReturnButton.TabIndex = 0;
            this.processReturnButton.Text = "Process Return";
            this.processReturnButton.UseVisualStyleBackColor = true;
            this.processReturnButton.Click += new System.EventHandler(this.ProcessReturnButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(137, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 27);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.returnTransactionDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.upperTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(12, 3);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.14533F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.85467F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(730, 289);
            this.mainTableLayoutPanel.TabIndex = 2;
            // 
            // returnTransactionDataGridView
            // 
            this.returnTransactionDataGridView.AllowUserToAddRows = false;
            this.returnTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn,
            this.transactionIDColumn,
            this.itemIDColumn,
            this.itemNameColumn,
            this.rentedQuantityColumn,
            this.dueDateColumn,
            this.dailyRateColumn,
            this.returnQuantityColumn});
            this.returnTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnTransactionDataGridView.Location = new System.Drawing.Point(3, 67);
            this.returnTransactionDataGridView.Name = "returnTransactionDataGridView";
            this.returnTransactionDataGridView.Size = new System.Drawing.Size(724, 219);
            this.returnTransactionDataGridView.TabIndex = 0;
            // 
            // selectColumn
            // 
            this.selectColumn.HeaderText = "Select";
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.Width = 50;
            // 
            // transactionIDColumn
            // 
            this.transactionIDColumn.HeaderText = "Transaction ID";
            this.transactionIDColumn.Name = "transactionIDColumn";
            this.transactionIDColumn.ReadOnly = true;
            this.transactionIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // itemIDColumn
            // 
            this.itemIDColumn.HeaderText = "Item ID";
            this.itemIDColumn.Name = "itemIDColumn";
            this.itemIDColumn.ReadOnly = true;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.HeaderText = "Item Name";
            this.itemNameColumn.Name = "itemNameColumn";
            this.itemNameColumn.ReadOnly = true;
            // 
            // rentedQuantityColumn
            // 
            this.rentedQuantityColumn.HeaderText = "Rented Quantity";
            this.rentedQuantityColumn.Name = "rentedQuantityColumn";
            this.rentedQuantityColumn.ReadOnly = true;
            // 
            // dueDateColumn
            // 
            this.dueDateColumn.HeaderText = "Due Date";
            this.dueDateColumn.Name = "dueDateColumn";
            this.dueDateColumn.ReadOnly = true;
            // 
            // dailyRateColumn
            // 
            this.dailyRateColumn.HeaderText = "Daily Rate";
            this.dailyRateColumn.Name = "dailyRateColumn";
            this.dailyRateColumn.ReadOnly = true;
            // 
            // returnQuantityColumn
            // 
            this.returnQuantityColumn.HeaderText = "Return Quantity";
            this.returnQuantityColumn.MaxDropDownItems = 100;
            this.returnQuantityColumn.Name = "returnQuantityColumn";
            this.returnQuantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.returnQuantityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // upperTableLayoutPanel
            // 
            this.upperTableLayoutPanel.ColumnCount = 2;
            this.upperTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.15493F));
            this.upperTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.84507F));
            this.upperTableLayoutPanel.Controls.Add(this.upperLeftLayoutPanel, 0, 0);
            this.upperTableLayoutPanel.Controls.Add(this.upperRightLayoutPanel, 1, 0);
            this.upperTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.upperTableLayoutPanel.Name = "upperTableLayoutPanel";
            this.upperTableLayoutPanel.RowCount = 2;
            this.upperTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.upperTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.upperTableLayoutPanel.Size = new System.Drawing.Size(724, 58);
            this.upperTableLayoutPanel.TabIndex = 1;
            // 
            // upperLeftLayoutPanel
            // 
            this.upperLeftLayoutPanel.ColumnCount = 2;
            this.upperLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.53623F));
            this.upperLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.46377F));
            this.upperLeftLayoutPanel.Controls.Add(this.customerIDLabel, 0, 0);
            this.upperLeftLayoutPanel.Controls.Add(this.customerFlowLayoutPanel, 1, 0);
            this.upperLeftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperLeftLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.upperLeftLayoutPanel.Name = "upperLeftLayoutPanel";
            this.upperLeftLayoutPanel.RowCount = 2;
            this.upperLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.upperLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.upperLeftLayoutPanel.Size = new System.Drawing.Size(422, 44);
            this.upperLeftLayoutPanel.TabIndex = 0;
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(6, 7);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(103, 20);
            this.customerIDLabel.TabIndex = 0;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // ReturnManagementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rentalTransactionTableLayout);
            this.Name = "ReturnManagementUserControl";
            this.Size = new System.Drawing.Size(745, 377);
            this.upperRightLayoutPanel.ResumeLayout(false);
            this.upperRightLayoutPanel.PerformLayout();
            this.customerFlowLayoutPanel.ResumeLayout(false);
            this.customerFlowLayoutPanel.PerformLayout();
            this.rentalTransactionTableLayout.ResumeLayout(false);
            this.lowerTableLayoutPanel.ResumeLayout(false);
            this.lowerLeftLayoutPanel.ResumeLayout(false);
            this.lowerLeftLayoutPanel.PerformLayout();
            this.lowerRightLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionDataGridView)).EndInit();
            this.upperTableLayoutPanel.ResumeLayout(false);
            this.upperLeftLayoutPanel.ResumeLayout(false);
            this.upperLeftLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TableLayoutPanel upperRightLayoutPanel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.FlowLayoutPanel customerFlowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel rentalTransactionTableLayout;
        private System.Windows.Forms.TableLayoutPanel lowerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel lowerLeftLayoutPanel;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.TableLayoutPanel lowerRightLayoutPanel;
        private System.Windows.Forms.Button processReturnButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView returnTransactionDataGridView;
        private System.Windows.Forms.TableLayoutPanel upperTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel upperLeftLayoutPanel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentedQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyRateColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn returnQuantityColumn;
        private System.Windows.Forms.Label feesValueLabel;
    }
}
