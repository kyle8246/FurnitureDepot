using FurnitureDepot.Controller;
using FurnitureDepot.Model;
using System;
using System.Windows.Forms;

namespace FurnitureDepot.UserControls
{
    /// <summary>
    /// User control for editing member/customer information
    /// </summary>
    public partial class EditCustomerUserControl : UserControl
    {
        private EmployeeController employeeController;

        public EditCustomerUserControl()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
        }

        private void getMemberInfoButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (int.TryParse(memberIDTextBox.Text, out int memberID))
                {
                    Customer customer = this.employeeController.GetCustomerByMemberID(memberID);

                    if (customer != null)
                    {
                        this.lastNameTextBox.Text = customer.LastName;
                        this.firstNameTextBox.Text = customer.FirstName;
                        this.sexComboBox.SelectedItem = customer.Sex;
                        this.dobTextBox.Text = customer.DateOfBirth.ToString();
                        this.streetAddressTextBox.Text = customer.StreetAddress;
                        this.cityTextBox.Text = customer.City;
                        this.stateComboBox.SelectedItem = customer.State;
                        this.zipCodeTextBox.Text = customer.ZipCode;
                        this.contactPhoneTextBox.Text = customer.ContactPhone;
                    }
                    else
                    {
                        this.idErrorLabel.Text = "Member not found for the given ID.";
                        this.idErrorLabel.Visible = true;
                    }
                }
                else
                {
                    this.idErrorLabel.Text = "Please enter a valid Member ID.";
                    this.idErrorLabel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                this.idErrorLabel.Text = "Error: " + ex.Message;
                this.idErrorLabel.Visible = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.memberIDTextBox.Text = string.Empty;
            this.lastNameTextBox.Text = string.Empty;
            this.firstNameTextBox.Text = string.Empty;
            this.dobTextBox.Text= string.Empty;
            this.contactPhoneTextBox.Text= string.Empty;
            this.streetAddressTextBox.Text= string.Empty;
            this.cityTextBox.Text= string.Empty;
            this.zipCodeTextBox.Text = string.Empty;

            this.idErrorLabel.Visible = false;
            this.lastNameErrorLabel.Visible = false;
            this.firstNameErrorLabel.Visible = false;
            this.dobErrorLabel.Visible = false;
            this.contactPhoneErrorLabel.Visible = false;
            this.streetAddressErrorLabel.Visible = false;
        }

        private void memberIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.idErrorLabel.Visible = false;
        }
    }
}
