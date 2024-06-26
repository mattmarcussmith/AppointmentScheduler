namespace C969MatthewSmith.Forms.Report
{
    partial class ReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.reportGrid = new System.Windows.Forms.DataGridView();
            this.reportGridAppointment = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.reportAppointmentsButton = new System.Windows.Forms.Button();
            this.DataGridLeaders = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeaders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports";
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(741, 370);
            this.GenerateReportButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(60, 26);
            this.GenerateReportButton.TabIndex = 6;
            this.GenerateReportButton.Text = "Generate";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // reportGrid
            // 
            this.reportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Month});
            this.reportGrid.Location = new System.Drawing.Point(31, 249);
            this.reportGrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.RowHeadersWidth = 20;
            this.reportGrid.RowTemplate.Height = 24;
            this.reportGrid.Size = new System.Drawing.Size(770, 115);
            this.reportGrid.TabIndex = 7;
            // 
            // reportGridAppointment
            // 
            this.reportGridAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column3,
            this.Column4,
            this.Column5});
            this.reportGridAppointment.Location = new System.Drawing.Point(31, 68);
            this.reportGridAppointment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.reportGridAppointment.Name = "reportGridAppointment";
            this.reportGridAppointment.RowHeadersWidth = 51;
            this.reportGridAppointment.RowTemplate.Height = 24;
            this.reportGridAppointment.Size = new System.Drawing.Size(770, 115);
            this.reportGridAppointment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(28, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Schedule for each user";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label5.Location = new System.Drawing.Point(28, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Appointment Types By month";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(727, 42);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(74, 20);
            this.comboBox3.TabIndex = 11;
            // 
            // reportAppointmentsButton
            // 
            this.reportAppointmentsButton.Location = new System.Drawing.Point(741, 200);
            this.reportAppointmentsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.reportAppointmentsButton.Name = "reportAppointmentsButton";
            this.reportAppointmentsButton.Size = new System.Drawing.Size(60, 19);
            this.reportAppointmentsButton.TabIndex = 12;
            this.reportAppointmentsButton.Text = "Generate";
            this.reportAppointmentsButton.UseVisualStyleBackColor = true;
            this.reportAppointmentsButton.Click += new System.EventHandler(this.ReportAppointmentsButton_Click);
            // 
            // DataGridLeaders
            // 
            this.DataGridLeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridLeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.Phone});
            this.DataGridLeaders.Location = new System.Drawing.Point(31, 430);
            this.DataGridLeaders.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataGridLeaders.Name = "DataGridLeaders";
            this.DataGridLeaders.RowHeadersWidth = 51;
            this.DataGridLeaders.RowTemplate.Height = 24;
            this.DataGridLeaders.Size = new System.Drawing.Size(770, 115);
            this.DataGridLeaders.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(28, 410);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Company founders";
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "Company Leadership";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.Width = 500;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 220;
            // 
            // Column0
            // 
            this.Column0.DataPropertyName = "Type";
            this.Column0.HeaderText = "Type";
            this.Column0.MinimumWidth = 6;
            this.Column0.Name = "Column0";
            this.Column0.Width = 225;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Start";
            this.Column3.HeaderText = "Start";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "UserName";
            this.Column4.HeaderText = "User name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "User ID";
            this.Column5.HeaderText = "User ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Type";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Number of Appointments";
            this.Column2.MinimumWidth = 200;
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Start";
            this.Month.HeaderText = "Month";
            this.Month.MinimumWidth = 200;
            this.Month.Name = "Month";
            this.Month.Width = 250;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 597);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataGridLeaders);
            this.Controls.Add(this.reportAppointmentsButton);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportGridAppointment);
            this.Controls.Add(this.reportGrid);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.DataGridView reportGrid;
        private System.Windows.Forms.DataGridView reportGridAppointment;
        private System.Windows.Forms.Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button reportAppointmentsButton;
        private System.Windows.Forms.DataGridView DataGridLeaders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
    }
}