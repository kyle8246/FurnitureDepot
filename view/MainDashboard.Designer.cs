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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.dashboardTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardTabControl
            // 
            this.dashboardTabControl.Controls.Add(this.registrationTabPage);
            this.dashboardTabControl.Controls.Add(this.editTabPage);
            this.dashboardTabControl.Controls.Add(this.searchTabPage);
            this.dashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dashboardTabControl.Location = new System.Drawing.Point(0, 34);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 0;
            this.dashboardTabControl.Size = new System.Drawing.Size(800, 416);
            this.dashboardTabControl.TabIndex = 0;
            // 
            // registrationTabPage
            // 
            this.registrationTabPage.Location = new System.Drawing.Point(4, 25);
            this.registrationTabPage.Name = "registrationTabPage";
            this.registrationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registrationTabPage.Size = new System.Drawing.Size(792, 387);
            this.registrationTabPage.TabIndex = 0;
            this.registrationTabPage.Text = "Customer Registration";
            this.registrationTabPage.UseVisualStyleBackColor = true;
            // 
            // editTabPage
            // 
            this.editTabPage.Location = new System.Drawing.Point(4, 25);
            this.editTabPage.Name = "editTabPage";
            this.editTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.editTabPage.Size = new System.Drawing.Size(792, 387);
            this.editTabPage.TabIndex = 1;
            this.editTabPage.Text = "Edit Customer";
            this.editTabPage.UseVisualStyleBackColor = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(638, 15);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 16);
            this.usernameLabel.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(728, 15);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(48, 16);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // searchTabPage
            // 
            this.searchTabPage.Location = new System.Drawing.Point(4, 25);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Size = new System.Drawing.Size(792, 387);
            this.searchTabPage.TabIndex = 2;
            this.searchTabPage.Text = "Search Customer";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.dashboardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.dashboardTabControl.ResumeLayout(false);
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
    }
}