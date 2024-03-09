using FurnitureDepot.DAL;
using FurnitureDepot.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureDepot.View
{
	public partial class RegisterCustomer : UserControl
	{
		public RegisterCustomer()
		{
			InitializeComponent();

			sexComboBox.Items.Add("M");
			sexComboBox.Items.Add("F");
			sexComboBox.Items.Add("Other");
			sexComboBox.SelectedIndex = 0;

			stateComboBox.Items.Add("AL");
			stateComboBox.Items.Add("AK");
			stateComboBox.Items.Add("AZ");
			stateComboBox.Items.Add("AR");
			stateComboBox.Items.Add("CA");
			stateComboBox.Items.Add("CO");
			stateComboBox.Items.Add("CT");
			stateComboBox.Items.Add("DE");
			stateComboBox.Items.Add("FL");
			stateComboBox.Items.Add("GA");
			stateComboBox.Items.Add("HI");
			stateComboBox.Items.Add("ID");
			stateComboBox.Items.Add("IL");
			stateComboBox.Items.Add("IN");
			stateComboBox.Items.Add("IA");
			stateComboBox.Items.Add("KS");
			stateComboBox.Items.Add("KY");
			stateComboBox.Items.Add("LA");
			stateComboBox.Items.Add("ME");
			stateComboBox.Items.Add("MD");
			stateComboBox.Items.Add("MA");
			stateComboBox.Items.Add("MI");
			stateComboBox.Items.Add("MN");
			stateComboBox.Items.Add("MS");
			stateComboBox.Items.Add("MO");
			stateComboBox.Items.Add("MT");
			stateComboBox.Items.Add("NE");
			stateComboBox.Items.Add("NV");
			stateComboBox.Items.Add("NH");
			stateComboBox.Items.Add("NJ");
			stateComboBox.Items.Add("NM");
			stateComboBox.Items.Add("NY");
			stateComboBox.Items.Add("NC");
			stateComboBox.Items.Add("ND");
			stateComboBox.Items.Add("OH");
			stateComboBox.Items.Add("OK");
			stateComboBox.Items.Add("OR");
			stateComboBox.Items.Add("PA");
			stateComboBox.Items.Add("RI");
			stateComboBox.Items.Add("SC");
			stateComboBox.Items.Add("SD");
			stateComboBox.Items.Add("TN");
			stateComboBox.Items.Add("TX");
			stateComboBox.Items.Add("UT");
			stateComboBox.Items.Add("VT");
			stateComboBox.Items.Add("VA");
			stateComboBox.Items.Add("WA");
			stateComboBox.Items.Add("WV");
			stateComboBox.Items.Add("WI");
			stateComboBox.Items.Add("WY");
			stateComboBox.SelectedIndex = 0;
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			if (
				string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
				string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
				string.IsNullOrWhiteSpace(streetAddressTextBox.Text) ||
				string.IsNullOrWhiteSpace(cityTextBox.Text) ||
				string.IsNullOrWhiteSpace(zipTextBox.Text) ||
				string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
				sexComboBox.SelectedIndex == -1 ||
				stateComboBox.SelectedIndex == -1)
			{
				MessageBox.Show("All fields required.");
				return;
			}

            if (
				phoneTextBox.Text.Length != 10 || !phoneTextBox.Text.All(char.IsDigit))
			{
				MessageBox.Show("Phone number must be exactly 10 digits.");
                return;
            }

            if (
                zipTextBox.Text.Length != 5 || !zipTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Valid zip code required.");
                return;
            }

            Customer customer = new Customer()
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

			CustomerDAL dal = new CustomerDAL();
			bool success = dal.AddCustomer(customer);

			if (success)
			{
				MessageBox.Show("Customer registered successfully.");
			}
			else
			{
				MessageBox.Show("There was an error registering the customer.");
			}
		}
	}
}
