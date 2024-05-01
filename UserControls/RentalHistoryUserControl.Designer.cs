namespace FurnitureDepot.UserControls
{
    partial class RentalHistoryUserControl
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
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.rentalHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.rentalItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.clearButton = new System.Windows.Forms.Button();
            this.customerNamePhoneLabel = new System.Windows.Forms.Label();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentalHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(135, 17);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(198, 22);
            this.customerIDTextBox.TabIndex = 0;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.CustomerIDTextBox_TextChanged);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(43, 23);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(83, 16);
            this.customerIDLabel.TabIndex = 1;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(132, 52);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 16);
            this.messageLabel.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(355, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 31);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // rentalHistoryDataGridView
            // 
            this.rentalHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentalHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalHistoryDataGridView.Location = new System.Drawing.Point(3, 87);
            this.rentalHistoryDataGridView.Name = "rentalHistoryDataGridView";
            this.rentalHistoryDataGridView.RowTemplate.Height = 24;
            this.rentalHistoryDataGridView.Size = new System.Drawing.Size(1059, 187);
            this.rentalHistoryDataGridView.TabIndex = 4;
            // 
            // rentalItemsDataGridView
            // 
            this.rentalItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalItemsDataGridView.Location = new System.Drawing.Point(3, 280);
            this.rentalItemsDataGridView.Name = "rentalItemsDataGridView";
            this.rentalItemsDataGridView.RowTemplate.Height = 24;
            this.rentalItemsDataGridView.Size = new System.Drawing.Size(1059, 202);
            this.rentalItemsDataGridView.TabIndex = 5;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(453, 17);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 31);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // customerNamePhoneLabel
            // 
            this.customerNamePhoneLabel.AutoSize = true;
            this.customerNamePhoneLabel.Location = new System.Drawing.Point(691, 24);
            this.customerNamePhoneLabel.Name = "customerNamePhoneLabel";
            this.customerNamePhoneLabel.Size = new System.Drawing.Size(0, 16);
            this.customerNamePhoneLabel.TabIndex = 7;
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Location = new System.Drawing.Point(691, 53);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(0, 16);
            this.customerAddressLabel.TabIndex = 9;
            // 
            // RentalHistoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerAddressLabel);
            this.Controls.Add(this.customerNamePhoneLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.rentalItemsDataGridView);
            this.Controls.Add(this.rentalHistoryDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Name = "RentalHistoryUserControl";
            this.Size = new System.Drawing.Size(1065, 520);
            ((System.ComponentModel.ISupportInitialize)(this.rentalHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView rentalHistoryDataGridView;
        private System.Windows.Forms.DataGridView rentalItemsDataGridView;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label customerNamePhoneLabel;
        private System.Windows.Forms.Label customerAddressLabel;
    }
}
