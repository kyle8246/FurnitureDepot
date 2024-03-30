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
            this.cartGroupBox = new System.Windows.Forms.GroupBox();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.buttonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.emptyCartButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.furnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minusButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cartQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plusButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteLineItemButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cartErrorLabel = new System.Windows.Forms.Label();
            this.rentalTransactionTableLayout.SuspendLayout();
            this.cartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.buttonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentalTransactionTableLayout
            // 
            this.rentalTransactionTableLayout.ColumnCount = 2;
            this.rentalTransactionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.94631F));
            this.rentalTransactionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.05369F));
            this.rentalTransactionTableLayout.Controls.Add(this.cartGroupBox, 1, 0);
            this.rentalTransactionTableLayout.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.rentalTransactionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTransactionTableLayout.Location = new System.Drawing.Point(0, 0);
            this.rentalTransactionTableLayout.Name = "rentalTransactionTableLayout";
            this.rentalTransactionTableLayout.RowCount = 2;
            this.rentalTransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.96552F));
            this.rentalTransactionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.rentalTransactionTableLayout.Size = new System.Drawing.Size(745, 377);
            this.rentalTransactionTableLayout.TabIndex = 0;
            // 
            // cartGroupBox
            // 
            this.cartGroupBox.Controls.Add(this.cartDataGridView);
            this.cartGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartGroupBox.Location = new System.Drawing.Point(92, 3);
            this.cartGroupBox.Name = "cartGroupBox";
            this.cartGroupBox.Size = new System.Drawing.Size(650, 254);
            this.cartGroupBox.TabIndex = 0;
            this.cartGroupBox.TabStop = false;
            this.cartGroupBox.Text = "Your Cart";
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.furnitureName,
            this.unitPrice,
            this.minusButton,
            this.cartQuantity,
            this.plusButton,
            this.deleteLineItemButton});
            this.cartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartDataGridView.Location = new System.Drawing.Point(3, 22);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.Size = new System.Drawing.Size(644, 229);
            this.cartDataGridView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.92308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.07692F));
            this.tableLayoutPanel1.Controls.Add(this.totalPriceLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cartErrorLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(92, 263);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 111);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(425, 26);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(200, 29);
            this.totalPriceLabel.TabIndex = 0;
            this.totalPriceLabel.Text = "Total Price: $0.00";
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.ColumnCount = 2;
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.buttonLayoutPanel.Controls.Add(this.emptyCartButton, 0, 0);
            this.buttonLayoutPanel.Controls.Add(this.checkoutButton, 1, 0);
            this.buttonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.RowCount = 1;
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel.Size = new System.Drawing.Size(416, 49);
            this.buttonLayoutPanel.TabIndex = 1;
            // 
            // emptyCartButton
            // 
            this.emptyCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyCartButton.Location = new System.Drawing.Point(3, 3);
            this.emptyCartButton.Name = "emptyCartButton";
            this.emptyCartButton.Size = new System.Drawing.Size(201, 43);
            this.emptyCartButton.TabIndex = 0;
            this.emptyCartButton.Text = "Empty Cart";
            this.emptyCartButton.UseVisualStyleBackColor = true;
            this.emptyCartButton.Click += new System.EventHandler(this.emptyCartButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(210, 3);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(203, 43);
            this.checkoutButton.TabIndex = 1;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // furnitureName
            // 
            this.furnitureName.HeaderText = "Name";
            this.furnitureName.Name = "furnitureName";
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.Name = "unitPrice";
            // 
            // minusButton
            // 
            this.minusButton.HeaderText = "Minus";
            this.minusButton.Name = "minusButton";
            this.minusButton.Text = "\"-\"";
            this.minusButton.UseColumnTextForButtonValue = true;
            // 
            // cartQuantity
            // 
            this.cartQuantity.HeaderText = "Quantity";
            this.cartQuantity.Name = "cartQuantity";
            // 
            // plusButton
            // 
            this.plusButton.HeaderText = "Add";
            this.plusButton.Name = "plusButton";
            this.plusButton.Text = "\"+\"";
            this.plusButton.UseColumnTextForButtonValue = true;
            // 
            // deleteLineItemButton
            // 
            this.deleteLineItemButton.HeaderText = "Delete";
            this.deleteLineItemButton.Name = "deleteLineItemButton";
            this.deleteLineItemButton.Text = "X";
            this.deleteLineItemButton.UseColumnTextForButtonValue = true;
            // 
            // cartErrorLabel
            // 
            this.cartErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartErrorLabel.AutoSize = true;
            this.cartErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.cartErrorLabel.Location = new System.Drawing.Point(3, 55);
            this.cartErrorLabel.Name = "cartErrorLabel";
            this.cartErrorLabel.Size = new System.Drawing.Size(416, 56);
            this.cartErrorLabel.TabIndex = 2;
            this.cartErrorLabel.Text = "There\'s been an error with the checkout.";
            // 
            // RentalTransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rentalTransactionTableLayout);
            this.Name = "RentalTransactionUserControl";
            this.Size = new System.Drawing.Size(745, 377);
            this.rentalTransactionTableLayout.ResumeLayout(false);
            this.cartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.buttonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rentalTransactionTableLayout;
        private System.Windows.Forms.GroupBox cartGroupBox;
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TableLayoutPanel buttonLayoutPanel;
        private System.Windows.Forms.Button emptyCartButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewButtonColumn minusButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn plusButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteLineItemButton;
        private System.Windows.Forms.Label cartErrorLabel;
    }
}
