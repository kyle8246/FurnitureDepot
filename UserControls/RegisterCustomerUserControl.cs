using FurnitureDepot.Controller;
using FurnitureDepot.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FurnitureDepot.View
{
	public partial class RegisterCustomerUserControl : UserControl
	{

		private readonly CustomerController customerController;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterCustomerUserControl"/> class.
        /// </summary>
        public RegisterCustomerUserControl()
        {
            InitializeComponent();
            customerController = new CustomerController();

            sexComboBox.Items.Insert(0, "-- Select --");
            stateComboBox.Items.Insert(0, "-- Select --");
            sexComboBox.SelectedIndex = 0;
            stateComboBox.SelectedIndex = 0;

            PopulateStates();
            sexComboBox.Items.AddRange(new object[] { "M", "F", "Other" });
        }

        private void PopulateStates()
        {
            string[] states = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
            stateComboBox.Items.AddRange(states);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                var customer = new Customer
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Sex = sexComboBox.SelectedItem.ToString(),
                    DateOfBirth = dobPicker.Value,
                    StreetAddress = streetAddressTextBox.Text,
                    City = cityTextBox.Text,
                    State = stateComboBox.SelectedItem.ToString(),
                    ZipCode = zipTextBox.Text,
                    ContactPhone = phoneTextBox.Text
                };

                if (customerController.CheckIfCustomerExists(customer.ContactPhone))
                {
                    statusLabel.Text = "A customer with this phone number already exists.";
                    statusLabel.ForeColor = Color.Red;
                }
                else
                {
                    bool success = customerController.RegisterCustomer(customer);
                    if (success)
                    {
                        statusLabel.Text = "Customer registered successfully.";
                        statusLabel.ForeColor = Color.Green;
                        ClearForm(); // Clear form only if registration is successful
                    }
                    else
                    {
                        statusLabel.Text = "There was an error registering the customer.";
                        statusLabel.ForeColor = Color.Red;
                    }
                }
                statusLabel.Visible = true;
            }
        }


        private void ClearForm()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            streetAddressTextBox.Clear();
            cityTextBox.Clear();
            zipTextBox.Clear();
            phoneTextBox.Clear();

            sexComboBox.SelectedIndex = 0;
            stateComboBox.SelectedIndex = 0;

            dobPicker.Value = DateTime.Now;

            statusLabel.Visible = false;
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(streetAddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(cityTextBox.Text) ||
                string.IsNullOrWhiteSpace(zipTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
                sexComboBox.SelectedIndex == -1 ||
                stateComboBox.SelectedIndex == -1)
            {
                statusLabel.Text = "All fields are required.";
                statusLabel.ForeColor = Color.Red;
                statusLabel.Visible = true;
                return false;
            }

            if (sexComboBox.SelectedIndex == 0 || stateComboBox.SelectedIndex == 0)
            {
                statusLabel.Text = "Please select a value for Sex and State.";
                statusLabel.ForeColor = Color.Red;
                statusLabel.Visible = true;
                return false;
            }

            if (phoneTextBox.Text.Length != 10 || !phoneTextBox.Text.All(char.IsDigit))
            {
                statusLabel.Text = "Phone number must be exactly 10 digits.";
                statusLabel.ForeColor = Color.Red;
                statusLabel.Visible = true;
                return false;
            }

            if (zipTextBox.Text.Length != 5 || !zipTextBox.Text.All(char.IsDigit))
            {
                statusLabel.Text = "Valid zip code is required.";
                statusLabel.ForeColor = Color.Red;
                statusLabel.Visible = true;
                return false;
            }

            return true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}