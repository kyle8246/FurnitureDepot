namespace FurnitureDepot.View
{
    partial class MainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboardTabControl = new System.Windows.Forms.TabControl();
            this.registrationTabPage = new System.Windows.Forms.TabPage();
            this.registerCustomerUserControl1 = new FurnitureDepot.View.RegisterCustomerUserControl();
            this.editTabPage = new System.Windows.Forms.TabPage();
            this.editCustomerUserControl = new FurnitureDepot.UserControls.EditCustomerUserControl();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.searchCustomerUserControl1 = new FurnitureDepot.UserControls.SearchCustomerUserControl();
            this.searchFurnitureTabPage = new System.Windows.Forms.TabPage();
            this.searchFurnitureUserControl1 = new FurnitureDepot.UserControls.SearchFurnitureUserControl();
            this.rentalTransactionTabPage = new System.Windows.Forms.TabPage();
            this.rentalTransactionUserControl1 = new FurnitureDepot.UserControls.RentalTransactionUserControl();
            this.rentalHistoryTabPage = new System.Windows.Forms.TabPage();
            this.rentalHistoryUserControl1 = new FurnitureDepot.UserControls.RentalHistoryUserControl();
            this.returnManagementTabPage = new System.Windows.Forms.TabPage();
            this.returnManagementUserControl1 = new FurnitureDepot.UserControls.ReturnManagementUserControl();
            this.returnHistoryTabPage = new System.Windows.Forms.TabPage();
            this.adminReportTabPage = new System.Windows.Forms.TabPage();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dashboardTabControl.SuspendLayout();
            this.registrationTabPage.SuspendLayout();
            this.editTabPage.SuspendLayout();
            this.searchTabPage.SuspendLayout();
            this.searchFurnitureTabPage.SuspendLayout();
            this.rentalTransactionTabPage.SuspendLayout();
            this.rentalHistoryTabPage.SuspendLayout();
            this.returnManagementTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardTabControl
            // 
            this.dashboardTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardTabControl.Controls.Add(this.registrationTabPage);
            this.dashboardTabControl.Controls.Add(this.editTabPage);
            this.dashboardTabControl.Controls.Add(this.searchTabPage);
            this.dashboardTabControl.Controls.Add(this.searchFurnitureTabPage);
            this.dashboardTabControl.Controls.Add(this.rentalTransactionTabPage);
            this.dashboardTabControl.Controls.Add(this.rentalHistoryTabPage);
            this.dashboardTabControl.Controls.Add(this.returnManagementTabPage);
            this.dashboardTabControl.Controls.Add(this.returnHistoryTabPage);
            this.dashboardTabControl.Controls.Add(this.adminReportTabPage);
            this.dashboardTabControl.Location = new System.Drawing.Point(0, 27);
            this.dashboardTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 0;
            this.dashboardTabControl.Size = new System.Drawing.Size(798, 414);
            this.dashboardTabControl.TabIndex = 0;
            // 
            // registrationTabPage
            // 
            this.registrationTabPage.Controls.Add(this.registerCustomerUserControl1);
            this.registrationTabPage.Location = new System.Drawing.Point(4, 22);
            this.registrationTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.registrationTabPage.Name = "registrationTabPage";
            this.registrationTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.registrationTabPage.Size = new System.Drawing.Size(790, 388);
            this.registrationTabPage.TabIndex = 0;
            this.registrationTabPage.Text = "Customer Registration";
            this.registrationTabPage.UseVisualStyleBackColor = true;
            // 
            // registerCustomerUserControl1
            // 
            this.registerCustomerUserControl1.Location = new System.Drawing.Point(0, 0);
            this.registerCustomerUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.registerCustomerUserControl1.Name = "registerCustomerUserControl1";
            this.registerCustomerUserControl1.Size = new System.Drawing.Size(795, 390);
            this.registerCustomerUserControl1.TabIndex = 0;
            // 
            // editTabPage
            // 
            this.editTabPage.Controls.Add(this.editCustomerUserControl);
            this.editTabPage.Location = new System.Drawing.Point(4, 22);
            this.editTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.editTabPage.Name = "editTabPage";
            this.editTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.editTabPage.Size = new System.Drawing.Size(790, 388);
            this.editTabPage.TabIndex = 1;
            this.editTabPage.Text = "Edit Customer";
            this.editTabPage.UseVisualStyleBackColor = true;
            // 
            // editCustomerUserControl
            // 
            this.editCustomerUserControl.Location = new System.Drawing.Point(4, 5);
            this.editCustomerUserControl.Margin = new System.Windows.Forms.Padding(4);
            this.editCustomerUserControl.Name = "editCustomerUserControl";
            this.editCustomerUserControl.Size = new System.Drawing.Size(784, 379);
            this.editCustomerUserControl.TabIndex = 0;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.searchCustomerUserControl1);
            this.searchTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Size = new System.Drawing.Size(790, 388);
            this.searchTabPage.TabIndex = 2;
            this.searchTabPage.Text = "Search Customer";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // searchCustomerUserControl1
            // 
            this.searchCustomerUserControl1.Location = new System.Drawing.Point(-3, 0);
            this.searchCustomerUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchCustomerUserControl1.Name = "searchCustomerUserControl1";
            this.searchCustomerUserControl1.Size = new System.Drawing.Size(799, 388);
            this.searchCustomerUserControl1.TabIndex = 0;
            // 
            // searchFurnitureTabPage
            // 
            this.searchFurnitureTabPage.Controls.Add(this.searchFurnitureUserControl1);
            this.searchFurnitureTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchFurnitureTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.searchFurnitureTabPage.Name = "searchFurnitureTabPage";
            this.searchFurnitureTabPage.Size = new System.Drawing.Size(790, 388);
            this.searchFurnitureTabPage.TabIndex = 3;
            this.searchFurnitureTabPage.Text = "Search Furniture";
            this.searchFurnitureTabPage.UseVisualStyleBackColor = true;
            // 
            // searchFurnitureUserControl1
            // 
            this.searchFurnitureUserControl1.Location = new System.Drawing.Point(-4, 0);
            this.searchFurnitureUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.searchFurnitureUserControl1.Name = "searchFurnitureUserControl1";
            this.searchFurnitureUserControl1.Size = new System.Drawing.Size(799, 422);
            this.searchFurnitureUserControl1.TabIndex = 0;
            // 
            // rentalTransactionTabPage
            // 
            this.rentalTransactionTabPage.Controls.Add(this.rentalTransactionUserControl1);
            this.rentalTransactionTabPage.Location = new System.Drawing.Point(4, 22);
            this.rentalTransactionTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.rentalTransactionTabPage.Name = "rentalTransactionTabPage";
            this.rentalTransactionTabPage.Size = new System.Drawing.Size(790, 388);
            this.rentalTransactionTabPage.TabIndex = 4;
            this.rentalTransactionTabPage.Text = "Rental Transaction";
            this.rentalTransactionTabPage.UseVisualStyleBackColor = true;
            // 
            // rentalTransactionUserControl1
            // 
            this.rentalTransactionUserControl1.Location = new System.Drawing.Point(-4, 0);
            this.rentalTransactionUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.rentalTransactionUserControl1.Name = "rentalTransactionUserControl1";
            this.rentalTransactionUserControl1.Size = new System.Drawing.Size(791, 388);
            this.rentalTransactionUserControl1.TabIndex = 0;
            // 
            // rentalHistoryTabPage
            // 
            this.rentalHistoryTabPage.Controls.Add(this.rentalHistoryUserControl1);
            this.rentalHistoryTabPage.Location = new System.Drawing.Point(4, 22);
            this.rentalHistoryTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.rentalHistoryTabPage.Name = "rentalHistoryTabPage";
            this.rentalHistoryTabPage.Size = new System.Drawing.Size(790, 388);
            this.rentalHistoryTabPage.TabIndex = 5;
            this.rentalHistoryTabPage.Text = "Rental History";
            this.rentalHistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // rentalHistoryUserControl1
            // 
            this.rentalHistoryUserControl1.Location = new System.Drawing.Point(0, 0);
            this.rentalHistoryUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentalHistoryUserControl1.Name = "rentalHistoryUserControl1";
            this.rentalHistoryUserControl1.Size = new System.Drawing.Size(792, 388);
            this.rentalHistoryUserControl1.TabIndex = 0;
            // 
            // returnManagementTabPage
            // 
            this.returnManagementTabPage.Controls.Add(this.returnManagementUserControl1);
            this.returnManagementTabPage.Location = new System.Drawing.Point(4, 22);
            this.returnManagementTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.returnManagementTabPage.Name = "returnManagementTabPage";
            this.returnManagementTabPage.Size = new System.Drawing.Size(790, 388);
            this.returnManagementTabPage.TabIndex = 6;
            this.returnManagementTabPage.Text = "Return Management";
            this.returnManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // returnManagementUserControl1
            // 
            this.returnManagementUserControl1.Location = new System.Drawing.Point(-4, 0);
            this.returnManagementUserControl1.Name = "returnManagementUserControl1";
            this.returnManagementUserControl1.Size = new System.Drawing.Size(787, 377);
            this.returnManagementUserControl1.TabIndex = 0;
            // 
            // returnHistoryTabPage
            // 
            this.returnHistoryTabPage.Location = new System.Drawing.Point(4, 22);
            this.returnHistoryTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.returnHistoryTabPage.Name = "returnHistoryTabPage";
            this.returnHistoryTabPage.Size = new System.Drawing.Size(790, 388);
            this.returnHistoryTabPage.TabIndex = 7;
            this.returnHistoryTabPage.Text = "Return History";
            this.returnHistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // adminReportTabPage
            // 
            this.adminReportTabPage.Location = new System.Drawing.Point(4, 22);
            this.adminReportTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.adminReportTabPage.Name = "adminReportTabPage";
            this.adminReportTabPage.Size = new System.Drawing.Size(790, 388);
            this.adminReportTabPage.TabIndex = 8;
            this.adminReportTabPage.Text = "Admin Report";
            this.adminReportTabPage.UseVisualStyleBackColor = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(621, 7);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameLabel.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(734, 7);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(40, 13);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 440);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.dashboardTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FurnitureDepot - MainDashboard";
            this.dashboardTabControl.ResumeLayout(false);
            this.registrationTabPage.ResumeLayout(false);
            this.editTabPage.ResumeLayout(false);
            this.searchTabPage.ResumeLayout(false);
            this.searchFurnitureTabPage.ResumeLayout(false);
            this.rentalTransactionTabPage.ResumeLayout(false);
            this.rentalHistoryTabPage.ResumeLayout(false);
            this.returnManagementTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl dashboardTabControl;
        private System.Windows.Forms.TabPage registrationTabPage;
        private System.Windows.Forms.TabPage editTabPage;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabPage searchTabPage;
        private UserControls.EditCustomerUserControl editCustomerUserControl;
        private RegisterCustomerUserControl registerCustomerUserControl1;
        private System.Windows.Forms.TabPage searchFurnitureTabPage;
        private System.Windows.Forms.TabPage rentalTransactionTabPage;
        private System.Windows.Forms.TabPage rentalHistoryTabPage;
        private UserControls.SearchCustomerUserControl searchCustomerUserControl1;
        private UserControls.RentalHistoryUserControl rentalHistoryUserControl1;
        private UserControls.RentalTransactionUserControl rentalTransactionUserControl1;
        private UserControls.SearchFurnitureUserControl searchFurnitureUserControl1;
        private System.Windows.Forms.TabPage returnManagementTabPage;
        private System.Windows.Forms.TabPage returnHistoryTabPage;
        private System.Windows.Forms.TabPage adminReportTabPage;
        private UserControls.ReturnManagementUserControl returnManagementUserControl1;
    }
}