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
            this.furnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minusButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cartQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plusButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteLineItemButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rentalTransactionTableLayout.SuspendLayout();
            this.cartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rentalTransactionTableLayout
            // 
            this.rentalTransactionTableLayout.ColumnCount = 2;
            this.rentalTransactionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.50336F));
            this.rentalTransactionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.49664F));
            this.rentalTransactionTableLayout.Controls.Add(this.cartGroupBox, 1, 0);
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
            this.cartGroupBox.Location = new System.Drawing.Point(193, 3);
            this.cartGroupBox.Name = "cartGroupBox";
            this.cartGroupBox.Size = new System.Drawing.Size(549, 254);
            this.cartGroupBox.TabIndex = 0;
            this.cartGroupBox.TabStop = false;
            this.cartGroupBox.Text = "Your Cart";
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.furnitureName,
            this.minusButton,
            this.cartQuantity,
            this.plusButton,
            this.deleteLineItemButton});
            this.cartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartDataGridView.Location = new System.Drawing.Point(3, 22);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.Size = new System.Drawing.Size(543, 229);
            this.cartDataGridView.TabIndex = 0;
            // 
            // furnitureName
            // 
            this.furnitureName.HeaderText = "Name";
            this.furnitureName.Name = "furnitureName";
            this.furnitureName.Width = 215;
            // 
            // minusButton
            // 
            this.minusButton.HeaderText = "Minus";
            this.minusButton.Name = "minusButton";
            this.minusButton.Text = "-";
            this.minusButton.UseColumnTextForButtonValue = true;
            this.minusButton.Width = 60;
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
            this.plusButton.Text = "+";
            this.plusButton.UseColumnTextForButtonValue = true;
            this.plusButton.Width = 50;
            // 
            // deleteLineItemButton
            // 
            this.deleteLineItemButton.HeaderText = "Delete";
            this.deleteLineItemButton.Name = "deleteLineItemButton";
            this.deleteLineItemButton.Text = "X";
            this.deleteLineItemButton.UseColumnTextForButtonValue = true;
            this.deleteLineItemButton.Width = 75;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rentalTransactionTableLayout;
        private System.Windows.Forms.GroupBox cartGroupBox;
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureName;
        private System.Windows.Forms.DataGridViewButtonColumn minusButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn plusButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteLineItemButton;
    }
}
