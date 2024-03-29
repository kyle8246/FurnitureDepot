namespace FurnitureDepot.UserControls
{
    partial class SearchFurnitureUserControl
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.furnitureIDLabel = new System.Windows.Forms.Label();
            this.styleLabel = new System.Windows.Forms.Label();
            this.styleTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.furnitureDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(112, 80);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 22;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(118, 44);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(150, 20);
            this.categoryTextBox.TabIndex = 2;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.CategoryTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(118, 11);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(150, 20);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(62, 44);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 13;
            this.categoryLabel.Text = "Category:";
            // 
            // furnitureIDLabel
            // 
            this.furnitureIDLabel.AutoSize = true;
            this.furnitureIDLabel.Location = new System.Drawing.Point(49, 14);
            this.furnitureIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.furnitureIDLabel.Name = "furnitureIDLabel";
            this.furnitureIDLabel.Size = new System.Drawing.Size(65, 13);
            this.furnitureIDLabel.TabIndex = 12;
            this.furnitureIDLabel.Text = "Furniture ID:";
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Location = new System.Drawing.Point(329, 14);
            this.styleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(33, 13);
            this.styleLabel.TabIndex = 14;
            this.styleLabel.Text = "Style:";
            // 
            // styleTextBox
            // 
            this.styleTextBox.Location = new System.Drawing.Point(366, 14);
            this.styleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.styleTextBox.Name = "styleTextBox";
            this.styleTextBox.Size = new System.Drawing.Size(150, 20);
            this.styleTextBox.TabIndex = 1;
            this.styleTextBox.TextChanged += new System.EventHandler(this.StyleTextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(458, 74);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(56, 22);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(366, 74);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 22);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // furnitureDataGridView
            // 
            this.furnitureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.furnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureDataGridView.Location = new System.Drawing.Point(2, 115);
            this.furnitureDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.furnitureDataGridView.Name = "furnitureDataGridView";
            this.furnitureDataGridView.RowTemplate.Height = 24;
            this.furnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.furnitureDataGridView.Size = new System.Drawing.Size(628, 306);
            this.furnitureDataGridView.TabIndex = 25;
            // 
            // SearchFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.furnitureDataGridView);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.styleTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.styleLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.furnitureIDLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchFurnitureUserControl";
            this.Size = new System.Drawing.Size(631, 422);
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label furnitureIDLabel;
        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.TextBox styleTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView furnitureDataGridView;
    }
}
