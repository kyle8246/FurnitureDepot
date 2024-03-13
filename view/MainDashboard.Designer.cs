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
            this.editTabPage = new System.Windows.Forms.TabPage();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.searchCustomerUserControl1 = new FurnitureDepot.UserControls.SearchCustomerUserControl();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.editCustomerUserControl1 = new FurnitureDepot.UserControls.EditCustomerUserControl();
            this.dashboardTabControl.SuspendLayout();
            this.editTabPage.SuspendLayout();
            this.searchTabPage.SuspendLayout();
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
            this.dashboardTabControl.Location = new System.Drawing.Point(0, 27);
            this.dashboardTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 0;
            this.dashboardTabControl.Size = new System.Drawing.Size(641, 379);
            this.dashboardTabControl.TabIndex = 0;
            // 
            // registrationTabPage
            // 
            this.registrationTabPage.Location = new System.Drawing.Point(4, 22);
            this.registrationTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.registrationTabPage.Name = "registrationTabPage";
            this.registrationTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.registrationTabPage.Size = new System.Drawing.Size(633, 353);
            this.registrationTabPage.TabIndex = 0;
            this.registrationTabPage.Text = "Customer Registration";
            this.registrationTabPage.UseVisualStyleBackColor = true;
            // 
            // editTabPage
            // 
            this.editTabPage.Controls.Add(this.editCustomerUserControl1);
            this.editTabPage.Location = new System.Drawing.Point(4, 22);
            this.editTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.editTabPage.Name = "editTabPage";
            this.editTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.editTabPage.Size = new System.Drawing.Size(633, 353);
            this.editTabPage.TabIndex = 1;
            this.editTabPage.Text = "Edit Customer";
            this.editTabPage.UseVisualStyleBackColor = true;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.searchCustomerUserControl1);
            this.searchTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Size = new System.Drawing.Size(633, 353);
            this.searchTabPage.TabIndex = 2;
            this.searchTabPage.Text = "Search Customer";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // searchCustomerUserControl1
            // 
            this.searchCustomerUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCustomerUserControl1.Location = new System.Drawing.Point(2, 12);
            this.searchCustomerUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchCustomerUserControl1.Name = "searchCustomerUserControl1";
            this.searchCustomerUserControl1.Size = new System.Drawing.Size(165, 99);
            this.searchCustomerUserControl1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(433, 12);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameLabel.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(546, 12);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(40, 13);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // editCustomerUserControl1
            // 
            this.editCustomerUserControl1.Location = new System.Drawing.Point(5, 5);
            this.editCustomerUserControl1.Name = "editCustomerUserControl1";
            this.editCustomerUserControl1.Size = new System.Drawing.Size(626, 305);
            this.editCustomerUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 405);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.dashboardTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FurnitureDepot - MainDashboard";
            this.dashboardTabControl.ResumeLayout(false);
            this.editTabPage.ResumeLayout(false);
            this.searchTabPage.ResumeLayout(false);
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
        private UserControls.SearchCustomerUserControl searchCustomerUserControl1;
        private UserControls.EditCustomerUserControl editCustomerUserControl1;
    }
}