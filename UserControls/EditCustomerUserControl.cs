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
        private CustomerController customerController;
        private Customer originalCustomerData;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCustomerUserControl"/> class.
        /// </summary>
        public EditCustomerUserControl()
        {
            InitializeComponent();
            this.customerController = new CustomerController();
            PopulateSexComboBox();
            PopulateStates();
        }

        private void GetMemberInfoButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (int.TryParse(memberIDTextBox.Text, out int memberID))
                {
                    Customer customer = this.customerController.GetCustomerByMemberID(memberID);

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

                        originalCustomerData = customer;
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void MemberIDTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearErrorLabels();
        }

        private void PopulateSexComboBox()
        {
            sexComboBox.Items.Insert(0, "-- Select --");
            stateComboBox.Items.Insert(0, "-- Select --");
            sexComboBox.SelectedIndex = 0;
            stateComboBox.SelectedIndex = 0;

            sexComboBox.Items.AddRange(new object[] { "M", "F", "Other" });
        }

        private void PopulateStates()
        {
            string[] states = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
            stateComboBox.Items.AddRange(states);
        }

        private void ClearErrorLabels()
        {
            this.idErrorLabel.Visible = false;
            this.lastNameErrorLabel.Visible = false;
            this.firstNameErrorLabel.Visible = false;
            this.dobErrorLabel.Visible = false; 
            this.contactPhoneErrorLabel.Visible = false;
            this.streetAddressErrorLabel.Visible = false;
            this.sexErrorLabel.Visible = false;
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            this.memberIDTextBox.Text = string.Empty;
            this.lastNameTextBox.Text = string.Empty;
            this.firstNameTextBox.Text = string.Empty;
            this.dobTextBox.Text = string.Empty;
            this.contactPhoneTextBox.Text = string.Empty;
            this.streetAddressTextBox.Text = string.Empty;
            this.cityTextBox.Text = string.Empty;
            this.zipCodeTextBox.Text = string.Empty;

            this.idErrorLabel.Visible = false;
            this.lastNameErrorLabel.Visible = false;
            this.firstNameErrorLabel.Visible = false;
            this.dobErrorLabel.Visible = false;
            this.contactPhoneErrorLabel.Visible = false;
            this.streetAddressErrorLabel.Visible = false;
            this.sexErrorLabel.Visible = false;
            this.stateComboBox.SelectedIndex = 0;
            this.sexComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Populates the customer data.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        public void PopulateCustomerData(int customerId)
        {
            Customer customer = customerController.GetCustomerByMemberID(customerId);

            if (customer != null)
            {
                memberIDTextBox.Text = customer.MemberID.ToString();
                lastNameTextBox.Text = customer.LastName;
                firstNameTextBox.Text = customer.FirstName;
                sexComboBox.SelectedItem = customer.Sex;
                dobTextBox.Text = customer.DateOfBirth.ToString();
                streetAddressTextBox.Text = customer.StreetAddress;
                cityTextBox.Text = customer.City;
                stateComboBox.SelectedItem = customer.State;
                zipCodeTextBox.Text = customer.ZipCode;
                contactPhoneTextBox.Text = customer.ContactPhone;
            }
            else
            {
                idErrorLabel.Text = "Member not found for the given ID.";
                idErrorLabel.Visible = true;
            }
        }

        private void EditMemberButton_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();
            bool isValid = true;
            if (originalCustomerData == null)
            {
                this.idErrorLabel.Text = "Member must be retrieved first.";
                this.idErrorLabel.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(this.memberIDTextBox.Text))
            {
                this.idErrorLabel.Text = "ID required.";
                this.idErrorLabel.Visible = true;
                isValid = false;
            }

            if (!CheckForChanges())
            {
                this.contactPhoneErrorLabel.Text = "No updates to member.";
                this.contactPhoneErrorLabel.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.lastNameTextBox.Text))
            {
                this.lastNameErrorLabel.Text = "Last name required.";
                this.lastNameErrorLabel.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(this.firstNameTextBox.Text))
            {
                this.firstNameErrorLabel.Text = "First name required.";
                this.firstNameErrorLabel.Visible = true;
                isValid = false;
            }
            if (this.sexComboBox.SelectedIndex <= 0)
            {
                this.sexErrorLabel.Text = "Select a sex.";
                this.sexErrorLabel.Visible = true;
                isValid = false;
            }
            if (!DateTime.TryParse(this.dobTextBox.Text, out DateTime dob))
            {
                this.dobErrorLabel.Text = "Invalid DOB.";
                this.dobErrorLabel.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(this.streetAddressTextBox.Text))
            {
                this.streetAddressErrorLabel.Text = "Address required.";
                this.streetAddressErrorLabel.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(this.cityTextBox.Text))
            {
                this.streetAddressErrorLabel.Text = "City required.";
                this.streetAddressErrorLabel.Visible = true;
                isValid = false;
            }
            if (this.stateComboBox.SelectedIndex <= 0)
            {
                this.streetAddressErrorLabel.Text = "Select a state.";
                this.streetAddressErrorLabel.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(this.zipCodeTextBox.Text))
            {
                this.streetAddressErrorLabel.Text = "Zip required.";
                this.streetAddressErrorLabel.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(this.contactPhoneTextBox.Text))
            {
                this.contactPhoneErrorLabel.Text = "Contact phone required.";
                this.contactPhoneErrorLabel.Visible = true;
                isValid = false;
            }

            if (isValid)
            {
                try
                {
                    Customer customer = new Customer()
                    {
                        MemberID = int.Parse(memberIDTextBox.Text),
                        LastName = lastNameTextBox.Text,
                        FirstName = firstNameTextBox.Text,
                        Sex = sexComboBox.SelectedItem.ToString(),
                        DateOfBirth = DateTime.Parse(dobTextBox.Text),
                        StreetAddress = streetAddressTextBox.Text,
                        City = cityTextBox.Text,
                        State = stateComboBox.SelectedItem.ToString(),
                        ZipCode = zipCodeTextBox.Text,
                        ContactPhone = contactPhoneTextBox.Text
                    };

                    bool result = this.customerController.UpdateCustomer(customer);
                    if (result)
                    {
                        Clear();
                        this.contactPhoneErrorLabel.Text = "Customer updated.";
                        this.contactPhoneErrorLabel.Visible = true;
                    }
                    else
                    {
                        this.contactPhoneErrorLabel.Text = "Failed to update.";
                        this.contactPhoneErrorLabel.Visible = true;   
                    }
                }
                catch (Exception ex)
                {
                    this.contactPhoneErrorLabel.Text = ex.Message;
                    this.contactPhoneErrorLabel.Visible = true;
                }
            }
        }

        private bool CheckForChanges()
        {
            if (originalCustomerData == null) return false;

            DateTime.TryParse(dobTextBox.Text, out var dob);

            return !(originalCustomerData.LastName == lastNameTextBox.Text &&
                     originalCustomerData.FirstName == firstNameTextBox.Text &&
                     originalCustomerData.Sex == sexComboBox.SelectedItem.ToString() &&
                     originalCustomerData.DateOfBirth == dob.Date &&
                     originalCustomerData.StreetAddress == streetAddressTextBox.Text &&
                     originalCustomerData.City == cityTextBox.Text &&
                     originalCustomerData.State == stateComboBox.SelectedItem.ToString() &&
                     originalCustomerData.ZipCode == zipCodeTextBox.Text &&
                     originalCustomerData.ContactPhone == contactPhoneTextBox.Text);
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.lastNameErrorLabel.Visible = false;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.firstNameErrorLabel.Visible = false;
        }

        private void DobTextBox_TextChanged(object sender, EventArgs e)
        {
            this.dobErrorLabel.Visible = false;
        }

        private void ContactPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            this.contactPhoneErrorLabel.Visible = false;
        }

        private void StreetAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            this.streetAddressErrorLabel.Visible = false;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            this.streetAddressErrorLabel.Visible = false;
        }

        private void ZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            this.streetAddressErrorLabel.Visible = false;
        }
    }
}
