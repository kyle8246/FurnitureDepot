namespace FurnitureDepot.UserControls
{
    partial class ReturnHistoryUserControl
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
            this.clearButton = new System.Windows.Forms.Button();
            this.returnItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.returnHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(550, 24);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(56, 25);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // returnItemsDataGridView
            // 
            this.returnItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnItemsDataGridView.Location = new System.Drawing.Point(2, 234);
            this.returnItemsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.returnItemsDataGridView.Name = "returnItemsDataGridView";
            this.returnItemsDataGridView.RowTemplate.Height = 24;
            this.returnItemsDataGridView.Size = new System.Drawing.Size(794, 164);
            this.returnItemsDataGridView.TabIndex = 12;
            // 
            // returnHistoryDataGridView
            // 
            this.returnHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnHistoryDataGridView.Location = new System.Drawing.Point(2, 77);
            this.returnHistoryDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.returnHistoryDataGridView.Name = "returnHistoryDataGridView";
            this.returnHistoryDataGridView.RowTemplate.Height = 24;
            this.returnHistoryDataGridView.Size = new System.Drawing.Size(794, 152);
            this.returnHistoryDataGridView.TabIndex = 11;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(476, 24);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 25);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(309, 52);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 9;
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(242, 29);
            this.customerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(68, 13);
            this.customerIDLabel.TabIndex = 8;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(311, 24);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(150, 20);
            this.customerIDTextBox.TabIndex = 7;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.CustomerIDTextBox_TextChanged);

            // 
            // ReturnHistoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.returnItemsDataGridView);
            this.Controls.Add(this.returnHistoryDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Name = "ReturnHistoryUserControl";
            this.Size = new System.Drawing.Size(799, 422);
            ((System.ComponentModel.ISupportInitialize)(this.returnItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView returnItemsDataGridView;
        private System.Windows.Forms.DataGridView returnHistoryDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox customerIDTextBox;
    }
}
