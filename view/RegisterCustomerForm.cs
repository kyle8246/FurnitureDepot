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
    public partial class RegisterCustomerForm : Form
    {
        public RegisterCustomerForm()
        {
            InitializeComponent();

            sexComboBox.Items.Add("Male");
            sexComboBox.Items.Add("Female");
            sexComboBox.Items.Add("Other");
            sexComboBox.SelectedIndex = 0;
        }
    }
}
