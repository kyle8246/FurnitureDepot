using FurnitureDepot.Controller;
using FurnitureDepot.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FurnitureDepot.UserControls
{
    /// <summary>
    /// AdminReportUserControl Class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class AdminReportUserControl : UserControl
    {
        private ReportController reportController;
        private EmployeeController employeeController;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminReportUserControl"/> class.
        /// </summary>
        public AdminReportUserControl()
        {
            InitializeComponent();
            reportController = new ReportController();
            employeeController = new EmployeeController();

            this.startDatePicker.ValueChanged += DateChanged;
            this.endDatePicker.ValueChanged += DateChanged;
            this.VisibleChanged += AdminReportUserControl_VisibleChanged;

            SetupControlBasedOnUserRole();
        }

        private void SetupControlBasedOnUserRole()
        {
            if (!IsAdmin())
            {
                DisableReportingFeatures();
            }
        }

        private bool IsAdmin()
        {
            return employeeController.GetCurrentEmployeeRole(SessionManager.CurrentEmployeeID) == "Administrator";
        }

        private void DisableReportingFeatures()
        {
            generateReportButton.Enabled = false;
            startDatePicker.Enabled = false;
            endDatePicker.Enabled = false;
            messageLabel.Text = "You do not have permission to access this feature";
            messageLabel.ForeColor = Color.Red;
        }

        private void AdminReportUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && IsAdmin())
            {
                ResetView();
            }
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            if (endDate < startDate)
            {
                UpdateMessageLabel("End date should be after start date", true);
                return;
            }

            var reportData = reportController.GetReportData(startDate, endDate);
            if (reportData != null && reportData.Count > 0)
            {
                reportDataGridView.DataSource = reportData;
                UpdateMessageLabel("", false);
            }
            else
            {
                UpdateMessageLabel("No data available for the selected dates", true);
                reportDataGridView.DataSource = null;
            }
        }

        private void UpdateMessageLabel(string message, bool isError)
        {
            messageLabel.Text = message;
            messageLabel.ForeColor = isError ? Color.Red : Color.Black;
        }

        private void DateChanged(object sender, EventArgs e)
        {
            if (IsAdmin())
            {
                messageLabel.Text = "";
                reportDataGridView.DataSource = null;
            }
        }

        private void ResetView()
        {
            startDatePicker.Value = DateTime.Today;
            endDatePicker.Value = DateTime.Today;
            messageLabel.Text = "";
            reportDataGridView.DataSource = null;
        }
    }
}
