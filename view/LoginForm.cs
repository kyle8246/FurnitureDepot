using FurnitureDepot.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FurnitureDepot.View
{
    /// <summary>
    /// Login Form class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.messageLabel.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();

            var username = this.usernameTextBox.Text;
            var password = this.passwordTextBox.Text;

            if (loginController.Authenticate(username, password))
            {
                using (MainDashboard mainForm = new MainDashboard())
                {
                    this.Hide();

                    mainForm.SetUser(username);
                    DialogResult result = mainForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        this.ClearFields();
                        this.Show();
                        this.usernameTextBox.Focus();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                messageLabel.Text = "Invalid username/password";
                messageLabel.ForeColor = Color.Red;
                messageLabel.Visible = true;
            }
        }

        private void ClearFields()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void UsernameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
        }

        private void PasswordTextBox_TextChanged_1(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
        }
    }
}
