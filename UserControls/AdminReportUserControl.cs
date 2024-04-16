using FurnitureDepot.Controller;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminReportUserControl"/> class.
        /// </summary>
        public AdminReportUserControl()
        {
            InitializeComponent();
            reportController = new ReportController();
            this.startDatePicker.ValueChanged += DateChanged;
            this.endDatePicker.ValueChanged += DateChanged;
            this.VisibleChanged += AdminReportUserControl_VisibleChanged;
        }

        private void AdminReportUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
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
            messageLabel.Text = "";
            reportDataGridView.DataSource = null;
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
