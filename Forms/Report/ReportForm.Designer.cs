﻿namespace C969MatthewSmith.Forms.Report
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.reportGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportGridAppointment = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.reportAppointmentsButton = new System.Windows.Forms.Button();
            this.DataGridLeaders = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeaders)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 475);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(473, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(296, 475);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(236, 33);
            this.comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(208, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Month";
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(461, 773);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(85, 35);
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
            this.Column2});
            this.reportGrid.Location = new System.Drawing.Point(44, 537);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.RowHeadersWidth = 51;
            this.reportGrid.RowTemplate.Height = 24;
            this.reportGrid.Size = new System.Drawing.Size(502, 213);
            this.reportGrid.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Number of Appointments";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // reportGridAppointment
            // 
            this.reportGridAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column3,
            this.Column4,
            this.Column5});
            this.reportGridAppointment.Location = new System.Drawing.Point(255, 122);
            this.reportGridAppointment.Name = "reportGridAppointment";
            this.reportGridAppointment.RowHeadersWidth = 51;
            this.reportGridAppointment.RowTemplate.Height = 24;
            this.reportGridAppointment.Size = new System.Drawing.Size(553, 182);
            this.reportGridAppointment.TabIndex = 8;
            // 
            // Column0
            // 
            this.Column0.DataPropertyName = "Type";
            this.Column0.HeaderText = "Type";
            this.Column0.MinimumWidth = 6;
            this.Column0.Name = "Column0";
            this.Column0.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Start";
            this.Column3.HeaderText = "Start";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "UserName";
            this.Column4.HeaderText = "User name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "User ID";
            this.Column5.HeaderText = "User ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(39, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Appointment for each consultant";
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.Location = new System.Drawing.Point(39, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Appointments";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(632, 66);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(176, 33);
            this.comboBox3.TabIndex = 11;
            // 
            // reportAppointmentsButton
            // 
            this.reportAppointmentsButton.Location = new System.Drawing.Point(698, 310);
            this.reportAppointmentsButton.Name = "reportAppointmentsButton";
            this.reportAppointmentsButton.Size = new System.Drawing.Size(110, 38);
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
            this.DataGridLeaders.Location = new System.Drawing.Point(583, 475);
            this.DataGridLeaders.Name = "DataGridLeaders";
            this.DataGridLeaders.RowHeadersWidth = 51;
            this.DataGridLeaders.RowTemplate.Height = 24;
            this.DataGridLeaders.Size = new System.Drawing.Size(301, 222);
            this.DataGridLeaders.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(578, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Leadership";
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "Chief Technology Officer";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "CTO PHONE";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 918);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataGridLeaders);
            this.Controls.Add(this.reportAppointmentsButton);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportGridAppointment);
            this.Controls.Add(this.reportGrid);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
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

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.DataGridView reportGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView reportGridAppointment;
        private System.Windows.Forms.Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button reportAppointmentsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView DataGridLeaders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}