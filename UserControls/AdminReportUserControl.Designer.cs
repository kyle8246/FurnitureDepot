namespace FurnitureDepot.UserControls
{
    partial class AdminReportUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Label messageLabel;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.Controls.Add(this.startDateLabel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.endDateLabel, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.startDatePicker, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.endDatePicker, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.generateReportButton, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.clearButton, 1, 2);
            this.mainLayoutPanel.Controls.Add(this.messageLabel, 1, 3);
            this.mainLayoutPanel.Controls.Add(this.reportDataGridView, 0, 4);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 5;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutPanel.Size = new System.Drawing.Size(1060, 478);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(458, 7);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(69, 16);
            this.startDateLabel.TabIndex = 0;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(461, 37);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(66, 16);
            this.endDateLabel.TabIndex = 1;
            this.endDateLabel.Text = "End Date:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(533, 3);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 22);
            this.startDatePicker.TabIndex = 2;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(533, 33);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 22);
            this.endDatePicker.TabIndex = 3;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.generateReportButton.Location = new System.Drawing.Point(422, 63);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(105, 24);
            this.generateReportButton.TabIndex = 4;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clearButton.Location = new System.Drawing.Point(533, 63);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 24);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(795, 97);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 16);
            this.messageLabel.TabIndex = 6;
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainLayoutPanel.SetColumnSpan(this.reportDataGridView, 2);
            this.reportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDataGridView.Location = new System.Drawing.Point(3, 123);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.Size = new System.Drawing.Size(1054, 352);
            this.reportDataGridView.TabIndex = 7;
            // 
            // AdminReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "AdminReportUserControl";
            this.Size = new System.Drawing.Size(1060, 478);
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
