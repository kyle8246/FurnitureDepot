namespace FurnitureDepot.UserControls
{
    partial class ReturnTransactionUserControl
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
            this.addRemoveButtonLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upperRightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.upperLeftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.furnitureLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.returnlTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.upperTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.lowerRightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.lowerLeftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lowerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rentalTransactionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.upperRightLayoutPanel.SuspendLayout();
            this.upperLeftLayoutPanel.SuspendLayout();
            this.customerFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnlTransactionDataGridView)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.upperTableLayoutPanel.SuspendLayout();
            this.lowerRightLayoutPanel.SuspendLayout();
            this.lowerLeftLayoutPanel.SuspendLayout();
            this.lowerTableLayoutPanel.SuspendLayout();
            this.rentalTransactionTableLayout.SuspendLayout();
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
            // addRemoveButtonLayoutPanel
            // 
            this.addRemoveButtonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRemoveButtonLayoutPanel.Location = new System.Drawing.Point(3, 45);
            this.addRemoveButtonLayoutPanel.Name = "addRemoveButtonLayoutPanel";
            this.addRemoveButtonLayoutPanel.Size = new System.Drawing.Size(279, 37);
            this.addRemoveButtonLayoutPanel.TabIndex = 1;
            // 
            // upperRightLayoutPanel
            // 
            this.upperRightLayoutPanel.ColumnCount = 1;
            this.upperRightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.upperRightLayoutPanel.Controls.Add(this.customerNameLabel, 0, 0);
            this.upperRightLayoutPanel.Controls.Add(this.addRemoveButtonLayoutPanel, 0, 1);
            this.upperRightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperRightLayoutPanel.Location = new System.Drawing.Point(423, 3);
            this.upperRightLayoutPanel.Name = "upperRightLayoutPanel";
            this.upperRightLayoutPanel.RowCount = 2;
            this.upperRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.upperRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.upperRightLayoutPanel.Size = new System.Drawing.Size(285, 85);
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
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(220, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(62, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // upperLeftLayoutPanel
            // 
            this.upperLeftLayoutPanel.ColumnCount = 2;
            this.upperLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.53623F));
            this.upperLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.46377F));
            this.upperLeftLayoutPanel.Controls.Add(this.customerFlowLayoutPanel, 1, 0);
            this.upperLeftLayoutPanel.Controls.Add(this.furnitureLabel, 0, 1);
            this.upperLeftLayoutPanel.Controls.Add(this.customerIDLabel, 0, 0);
            this.upperLeftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperLeftLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.upperLeftLayoutPanel.Name = "upperLeftLayoutPanel";
            this.upperLeftLayoutPanel.RowCount = 2;
            this.upperLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.38272F));
            this.upperLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.61728F));
            this.upperLeftLayoutPanel.Size = new System.Drawing.Size(414, 85);
            this.upperLeftLayoutPanel.TabIndex = 0;
            // 
            // customerFlowLayoutPanel
            // 
            this.customerFlowLayoutPanel.Controls.Add(this.customerIDTextBox);
            this.customerFlowLayoutPanel.Controls.Add(this.searchButton);
            this.customerFlowLayoutPanel.Controls.Add(this.clearButton);
            this.customerFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerFlowLayoutPanel.Location = new System.Drawing.Point(116, 3);
            this.customerFlowLayoutPanel.Name = "customerFlowLayoutPanel";
            this.customerFlowLayoutPanel.Size = new System.Drawing.Size(295, 35);
            this.customerFlowLayoutPanel.TabIndex = 2;
            // 
            // furnitureLabel
            // 
            this.furnitureLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.furnitureLabel.AutoSize = true;
            this.furnitureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureLabel.Location = new System.Drawing.Point(110, 53);
            this.furnitureLabel.Name = "furnitureLabel";
            this.furnitureLabel.Size = new System.Drawing.Size(0, 20);
            this.furnitureLabel.TabIndex = 1;
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(5, 10);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(103, 20);
            this.customerIDLabel.TabIndex = 0;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // returnlTransactionDataGridView
            // 
            this.returnlTransactionDataGridView.AllowUserToAddRows = false;
            this.returnlTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnlTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.itemID,
            this.itemName,
            this.rentedQuantity,
            this.dueDate,
            this.dailyRate,
            this.returnQuantity});
            this.returnlTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnlTransactionDataGridView.Location = new System.Drawing.Point(3, 114);
            this.returnlTransactionDataGridView.Name = "returnlTransactionDataGridView";
            this.returnlTransactionDataGridView.Size = new System.Drawing.Size(711, 172);
            this.returnlTransactionDataGridView.TabIndex = 0;
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "Select";
            this.checkbox.Name = "checkbox";
            this.checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // itemID
            // 
            this.itemID.HeaderText = "Item ID";
            this.itemID.Name = "itemID";
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            // 
            // rentedQuantity
            // 
            this.rentedQuantity.HeaderText = "Rented Quantity";
            this.rentedQuantity.Name = "rentedQuantity";
            // 
            // dueDate
            // 
            this.dueDate.HeaderText = "Due Date";
            this.dueDate.Name = "dueDate";
            // 
            // dailyRate
            // 
            this.dailyRate.HeaderText = "Daily Rate";
            this.dailyRate.Name = "dailyRate";
            // 
            // returnQuantity
            // 
            this.returnQuantity.HeaderText = "Return Quantity";
            this.returnQuantity.Name = "returnQuantity";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.returnlTransactionDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.upperTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(25, 3);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.60294F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.39706F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(717, 289);
            this.mainTableLayoutPanel.TabIndex = 2;
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
            this.upperTableLayoutPanel.Size = new System.Drawing.Size(711, 105);
            this.upperTableLayoutPanel.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButton.Location = new System.Drawing.Point(3, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(126, 27);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit Transaction";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(135, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 27);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // lowerRightLayoutPanel
            // 
            this.lowerRightLayoutPanel.ColumnCount = 2;
            this.lowerRightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lowerRightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lowerRightLayoutPanel.Controls.Add(this.submitButton, 0, 0);
            this.lowerRightLayoutPanel.Controls.Add(this.cancelButton, 1, 0);
            this.lowerRightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerRightLayoutPanel.Location = new System.Drawing.Point(450, 3);
            this.lowerRightLayoutPanel.Name = "lowerRightLayoutPanel";
            this.lowerRightLayoutPanel.RowCount = 2;
            this.lowerRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.lowerRightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.lowerRightLayoutPanel.Size = new System.Drawing.Size(264, 60);
            this.lowerRightLayoutPanel.TabIndex = 1;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(20, 1);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(67, 16);
            this.dueDateLabel.TabIndex = 0;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // lowerLeftLayoutPanel
            // 
            this.lowerLeftLayoutPanel.ColumnCount = 3;
            this.lowerLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.lowerLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.96552F));
            this.lowerLeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.lowerLeftLayoutPanel.Controls.Add(this.dueDateLabel, 0, 0);
            this.lowerLeftLayoutPanel.Controls.Add(this.returnDateLabel, 0, 1);
            this.lowerLeftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerLeftLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.lowerLeftLayoutPanel.Name = "lowerLeftLayoutPanel";
            this.lowerLeftLayoutPanel.RowCount = 3;
            this.lowerLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.33333F));
            this.lowerLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.66667F));
            this.lowerLeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.lowerLeftLayoutPanel.Size = new System.Drawing.Size(441, 60);
            this.lowerLeftLayoutPanel.TabIndex = 0;
            // 
            // lowerTableLayoutPanel
            // 
            this.lowerTableLayoutPanel.ColumnCount = 2;
            this.lowerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.43017F));
            this.lowerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.56983F));
            this.lowerTableLayoutPanel.Controls.Add(this.lowerLeftLayoutPanel, 0, 0);
            this.lowerTableLayoutPanel.Controls.Add(this.lowerRightLayoutPanel, 1, 0);
            this.lowerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerTableLayoutPanel.Location = new System.Drawing.Point(25, 298);
            this.lowerTableLayoutPanel.Name = "lowerTableLayoutPanel";
            this.lowerTableLayoutPanel.RowCount = 2;
            this.lowerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.8421F));
            this.lowerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.lowerTableLayoutPanel.Size = new System.Drawing.Size(717, 76);
            this.lowerTableLayoutPanel.TabIndex = 1;
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
            this.rentalTransactionTableLayout.Name = "rentalTransactionTableLayout";
            this.rentalTransactionTableLayout.RowCount = 2;
            this.rentalTransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.24934F));
            this.rentalTransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.75066F));
            this.rentalTransactionTableLayout.Size = new System.Drawing.Size(745, 377);
            this.rentalTransactionTableLayout.TabIndex = 1;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLabel.Location = new System.Drawing.Point(6, 23);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(81, 16);
            this.returnDateLabel.TabIndex = 1;
            this.returnDateLabel.Text = "Return Date:";
            // 
            // ReturnTransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rentalTransactionTableLayout);
            this.Name = "ReturnTransactionUserControl";
            this.Size = new System.Drawing.Size(745, 377);
            this.upperRightLayoutPanel.ResumeLayout(false);
            this.upperRightLayoutPanel.PerformLayout();
            this.upperLeftLayoutPanel.ResumeLayout(false);
            this.upperLeftLayoutPanel.PerformLayout();
            this.customerFlowLayoutPanel.ResumeLayout(false);
            this.customerFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnlTransactionDataGridView)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.upperTableLayoutPanel.ResumeLayout(false);
            this.lowerRightLayoutPanel.ResumeLayout(false);
            this.lowerLeftLayoutPanel.ResumeLayout(false);
            this.lowerLeftLayoutPanel.PerformLayout();
            this.lowerTableLayoutPanel.ResumeLayout(false);
            this.rentalTransactionTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.FlowLayoutPanel addRemoveButtonLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel upperRightLayoutPanel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TableLayoutPanel upperLeftLayoutPanel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.FlowLayoutPanel customerFlowLayoutPanel;
        private System.Windows.Forms.Label furnitureLabel;
        private System.Windows.Forms.DataGridView returnlTransactionDataGridView;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel upperTableLayoutPanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel lowerRightLayoutPanel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.TableLayoutPanel lowerLeftLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel lowerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel rentalTransactionTableLayout;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnQuantity;
        private System.Windows.Forms.Label returnDateLabel;
    }
}
