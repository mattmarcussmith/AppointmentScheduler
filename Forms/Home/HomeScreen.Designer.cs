namespace C969MatthewSmith.Forms.Home
{
    partial class HomeScreen
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
            this.CreateCustomerButton = new System.Windows.Forms.Button();
            this.DataGridCustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.ExitApplicationButton = new System.Windows.Forms.Button();
            this.DataGridAppointments = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllAppRadioButton = new System.Windows.Forms.RadioButton();
            this.CurrentWeekAppRadioButton = new System.Windows.Forms.RadioButton();
            this.CurrentMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.CreateAppointmentButton = new System.Windows.Forms.Button();
            this.UpdateAppointmentButton = new System.Windows.Forms.Button();
            this.DeleteAppointmentButton = new System.Windows.Forms.Button();
            this.CurrentDayRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateCustomerButton
            // 
            this.CreateCustomerButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CreateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCustomerButton.Location = new System.Drawing.Point(277, 713);
            this.CreateCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateCustomerButton.Name = "CreateCustomerButton";
            this.CreateCustomerButton.Size = new System.Drawing.Size(96, 37);
            this.CreateCustomerButton.TabIndex = 0;
            this.CreateCustomerButton.Text = "Create";
            this.CreateCustomerButton.UseVisualStyleBackColor = false;
            this.CreateCustomerButton.Click += new System.EventHandler(this.CreateCustomerButton_Click);
            // 
            // DataGridCustomers
            // 
            this.DataGridCustomers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridCustomers.Location = new System.Drawing.Point(161, 449);
            this.DataGridCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridCustomers.Name = "DataGridCustomers";
            this.DataGridCustomers.RowHeadersWidth = 82;
            this.DataGridCustomers.RowTemplate.Height = 33;
            this.DataGridCustomers.Size = new System.Drawing.Size(1135, 256);
            this.DataGridCustomers.TabIndex = 1;
            this.DataGridCustomers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridCustomers_CellFormatting);
            this.DataGridCustomers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridBindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerName";
            this.Column1.HeaderText = "Customer name";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 230;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Phone";
            this.Column2.HeaderText = "Phone";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "AddressName";
            this.Column3.HeaderText = "Address";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 230;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CountryName";
            this.Column4.HeaderText = "Country";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CityName";
            this.Column5.HeaderText = "City";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCustomerButton.Location = new System.Drawing.Point(380, 713);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(96, 37);
            this.UpdateCustomerButton.TabIndex = 2;
            this.UpdateCustomerButton.Text = "Update";
            this.UpdateCustomerButton.UseVisualStyleBackColor = false;
            this.UpdateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeleteCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCustomerButton.Location = new System.Drawing.Point(482, 714);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(96, 36);
            this.DeleteCustomerButton.TabIndex = 3;
            this.DeleteCustomerButton.Text = "Delete";
            this.DeleteCustomerButton.UseVisualStyleBackColor = false;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenerateReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateReportButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenerateReportButton.Location = new System.Drawing.Point(971, 716);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(151, 34);
            this.GenerateReportButton.TabIndex = 4;
            this.GenerateReportButton.Text = "Reports";
            this.GenerateReportButton.UseVisualStyleBackColor = false;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // ExitApplicationButton
            // 
            this.ExitApplicationButton.BackColor = System.Drawing.Color.IndianRed;
            this.ExitApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitApplicationButton.Location = new System.Drawing.Point(1128, 716);
            this.ExitApplicationButton.Name = "ExitApplicationButton";
            this.ExitApplicationButton.Size = new System.Drawing.Size(96, 34);
            this.ExitApplicationButton.TabIndex = 5;
            this.ExitApplicationButton.Text = "Exit";
            this.ExitApplicationButton.UseVisualStyleBackColor = false;
            this.ExitApplicationButton.Click += new System.EventHandler(this.ExitApplicationButton_Click);
            // 
            // DataGridAppointments
            // 
            this.DataGridAppointments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DataGridAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column8,
            this.Column11,
            this.Column9});
            this.DataGridAppointments.GridColor = System.Drawing.Color.White;
            this.DataGridAppointments.Location = new System.Drawing.Point(161, 95);
            this.DataGridAppointments.Name = "DataGridAppointments";
            this.DataGridAppointments.RowHeadersWidth = 51;
            this.DataGridAppointments.RowTemplate.Height = 33;
            this.DataGridAppointments.Size = new System.Drawing.Size(1135, 253);
            this.DataGridAppointments.TabIndex = 6;
            this.DataGridAppointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridAppointments_CellFormatting);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Type";
            this.Column6.HeaderText = "Type";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 180;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CustomerId";
            this.Column7.HeaderText = "Customer ID";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 180;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "CustomerName";
            this.Column10.HeaderText = "Customer name";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 180;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Start";
            this.Column8.HeaderText = "Start";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 180;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "End";
            this.Column11.HeaderText = "End";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 180;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "UserId";
            this.Column9.HeaderText = "User ID";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Appointments";
            // 
            // AllAppRadioButton
            // 
            this.AllAppRadioButton.AutoSize = true;
            this.AllAppRadioButton.Location = new System.Drawing.Point(444, 48);
            this.AllAppRadioButton.Name = "AllAppRadioButton";
            this.AllAppRadioButton.Size = new System.Drawing.Size(221, 29);
            this.AllAppRadioButton.TabIndex = 9;
            this.AllAppRadioButton.TabStop = true;
            this.AllAppRadioButton.Text = "All Appointments";
            this.AllAppRadioButton.UseVisualStyleBackColor = true;
            this.AllAppRadioButton.CheckedChanged += new System.EventHandler(this.AllAppRadioButton_CheckedChanged);
            // 
            // CurrentWeekAppRadioButton
            // 
            this.CurrentWeekAppRadioButton.AutoSize = true;
            this.CurrentWeekAppRadioButton.Location = new System.Drawing.Point(881, 48);
            this.CurrentWeekAppRadioButton.Name = "CurrentWeekAppRadioButton";
            this.CurrentWeekAppRadioButton.Size = new System.Drawing.Size(188, 29);
            this.CurrentWeekAppRadioButton.TabIndex = 10;
            this.CurrentWeekAppRadioButton.TabStop = true;
            this.CurrentWeekAppRadioButton.Text = "Current Week";
            this.CurrentWeekAppRadioButton.UseVisualStyleBackColor = true;
            this.CurrentWeekAppRadioButton.CheckedChanged += new System.EventHandler(this.CurrentWeekAppRadioButton_CheckedChanged);
            // 
            // CurrentMonthRadioButton
            // 
            this.CurrentMonthRadioButton.AutoSize = true;
            this.CurrentMonthRadioButton.Location = new System.Drawing.Point(1092, 48);
            this.CurrentMonthRadioButton.Name = "CurrentMonthRadioButton";
            this.CurrentMonthRadioButton.Size = new System.Drawing.Size(195, 29);
            this.CurrentMonthRadioButton.TabIndex = 11;
            this.CurrentMonthRadioButton.TabStop = true;
            this.CurrentMonthRadioButton.Text = "Current Month";
            this.CurrentMonthRadioButton.UseVisualStyleBackColor = true;
            this.CurrentMonthRadioButton.CheckedChanged += new System.EventHandler(this.CurrentMonthRadioButton_CheckedChanged);
            // 
            // CreateAppointmentButton
            // 
            this.CreateAppointmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CreateAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAppointmentButton.Location = new System.Drawing.Point(277, 354);
            this.CreateAppointmentButton.Name = "CreateAppointmentButton";
            this.CreateAppointmentButton.Size = new System.Drawing.Size(96, 36);
            this.CreateAppointmentButton.TabIndex = 12;
            this.CreateAppointmentButton.Text = "Create";
            this.CreateAppointmentButton.UseVisualStyleBackColor = false;
            this.CreateAppointmentButton.Click += new System.EventHandler(this.CreateAppointmentButton_Click);
            // 
            // UpdateAppointmentButton
            // 
            this.UpdateAppointmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateAppointmentButton.Location = new System.Drawing.Point(379, 354);
            this.UpdateAppointmentButton.Name = "UpdateAppointmentButton";
            this.UpdateAppointmentButton.Size = new System.Drawing.Size(96, 36);
            this.UpdateAppointmentButton.TabIndex = 13;
            this.UpdateAppointmentButton.Text = "Update";
            this.UpdateAppointmentButton.UseVisualStyleBackColor = false;
            this.UpdateAppointmentButton.Click += new System.EventHandler(this.UpdateAppointmentButton_Click);
            // 
            // DeleteAppointmentButton
            // 
            this.DeleteAppointmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeleteAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAppointmentButton.Location = new System.Drawing.Point(482, 354);
            this.DeleteAppointmentButton.Name = "DeleteAppointmentButton";
            this.DeleteAppointmentButton.Size = new System.Drawing.Size(96, 36);
            this.DeleteAppointmentButton.TabIndex = 14;
            this.DeleteAppointmentButton.Text = "Delete";
            this.DeleteAppointmentButton.UseVisualStyleBackColor = false;
            this.DeleteAppointmentButton.Click += new System.EventHandler(this.DeleteAppointmentButton_Click);
            // 
            // CurrentDayRadioButton
            // 
            this.CurrentDayRadioButton.AutoSize = true;
            this.CurrentDayRadioButton.Location = new System.Drawing.Point(671, 48);
            this.CurrentDayRadioButton.Name = "CurrentDayRadioButton";
            this.CurrentDayRadioButton.Size = new System.Drawing.Size(171, 29);
            this.CurrentDayRadioButton.TabIndex = 15;
            this.CurrentDayRadioButton.TabStop = true;
            this.CurrentDayRadioButton.Text = "Current Day";
            this.CurrentDayRadioButton.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1376, 829);
            this.Controls.Add(this.CurrentDayRadioButton);
            this.Controls.Add(this.DeleteAppointmentButton);
            this.Controls.Add(this.UpdateAppointmentButton);
            this.Controls.Add(this.CreateAppointmentButton);
            this.Controls.Add(this.CurrentMonthRadioButton);
            this.Controls.Add(this.CurrentWeekAppRadioButton);
            this.Controls.Add(this.AllAppRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridAppointments);
            this.Controls.Add(this.ExitApplicationButton);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.DeleteCustomerButton);
            this.Controls.Add(this.UpdateCustomerButton);
            this.Controls.Add(this.DataGridCustomers);
            this.Controls.Add(this.CreateCustomerButton);
            this.Font = new System.Drawing.Font("Verdana", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCustomerButton;
        public System.Windows.Forms.DataGridView DataGridCustomers;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.Button ExitApplicationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton AllAppRadioButton;
        private System.Windows.Forms.RadioButton CurrentWeekAppRadioButton;
        private System.Windows.Forms.RadioButton CurrentMonthRadioButton;
        private System.Windows.Forms.Button CreateAppointmentButton;
        private System.Windows.Forms.Button UpdateAppointmentButton;
        private System.Windows.Forms.Button DeleteAppointmentButton;
        public System.Windows.Forms.DataGridView DataGridAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.RadioButton CurrentDayRadioButton;
    }
}