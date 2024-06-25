namespace C969MatthewSmith.Forms.CreateAppointment
{
    partial class CreateAppointmentForm
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
            this.components = new System.ComponentModel.Container();
            this.InputCustomerNameAppoinment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveCustomerAppointmentButton = new System.Windows.Forms.Button();
            this.InputAppointmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.CancelCreateAppointmentButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label5 = new System.Windows.Forms.Label();
            this.InputAppointmentEndTime = new System.Windows.Forms.DateTimePicker();
            this.InputCustomerAppointmentType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputCustomerNameAppoinment
            // 
            this.InputCustomerNameAppoinment.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCustomerNameAppoinment.Location = new System.Drawing.Point(111, 460);
            this.InputCustomerNameAppoinment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputCustomerNameAppoinment.Name = "InputCustomerNameAppoinment";
            this.InputCustomerNameAppoinment.Size = new System.Drawing.Size(634, 27);
            this.InputCustomerNameAppoinment.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 594);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start";
            // 
            // SaveCustomerAppointmentButton
            // 
            this.SaveCustomerAppointmentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCustomerAppointmentButton.Location = new System.Drawing.Point(78, 912);
            this.SaveCustomerAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveCustomerAppointmentButton.Name = "SaveCustomerAppointmentButton";
            this.SaveCustomerAppointmentButton.Size = new System.Drawing.Size(288, 81);
            this.SaveCustomerAppointmentButton.TabIndex = 10;
            this.SaveCustomerAppointmentButton.Text = "Save";
            this.SaveCustomerAppointmentButton.UseVisualStyleBackColor = true;
            this.SaveCustomerAppointmentButton.Click += new System.EventHandler(this.SaveCustomerAppointmentButton_Click);
            // 
            // InputAppointmentDateTime
            // 
            this.InputAppointmentDateTime.CalendarFont = new System.Drawing.Font("Verdana", 14F);
            this.InputAppointmentDateTime.Font = new System.Drawing.Font("Verdana", 12F);
            this.InputAppointmentDateTime.Location = new System.Drawing.Point(116, 662);
            this.InputAppointmentDateTime.Name = "InputAppointmentDateTime";
            this.InputAppointmentDateTime.Size = new System.Drawing.Size(634, 27);
            this.InputAppointmentDateTime.TabIndex = 12;
            // 
            // CancelCreateAppointmentButton
            // 
            this.CancelCreateAppointmentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelCreateAppointmentButton.Location = new System.Drawing.Point(440, 912);
            this.CancelCreateAppointmentButton.Name = "CancelCreateAppointmentButton";
            this.CancelCreateAppointmentButton.Size = new System.Drawing.Size(288, 81);
            this.CancelCreateAppointmentButton.TabIndex = 14;
            this.CancelCreateAppointmentButton.Text = "Cancel";
            this.CancelCreateAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Create Appointment";
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
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 742);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "End";
            // 
            // InputAppointmentEndTime
            // 
            this.InputAppointmentEndTime.CalendarFont = new System.Drawing.Font("Verdana", 14F);
            this.InputAppointmentEndTime.Font = new System.Drawing.Font("Verdana", 12F);
            this.InputAppointmentEndTime.Location = new System.Drawing.Point(116, 802);
            this.InputAppointmentEndTime.Name = "InputAppointmentEndTime";
            this.InputAppointmentEndTime.Size = new System.Drawing.Size(634, 27);
            this.InputAppointmentEndTime.TabIndex = 17;
            this.InputAppointmentEndTime.Value = new System.DateTime(2024, 6, 2, 19, 2, 29, 0);
            // 
            // InputCustomerAppointmentType
            // 
            this.InputCustomerAppointmentType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCustomerAppointmentType.Location = new System.Drawing.Point(111, 221);
            this.InputCustomerAppointmentType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputCustomerAppointmentType.Name = "InputCustomerAppointmentType";
            this.InputCustomerAppointmentType.Size = new System.Drawing.Size(634, 27);
            this.InputCustomerAppointmentType.TabIndex = 1;
            // 
            // CreateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 1094);
            this.Controls.Add(this.InputAppointmentEndTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelCreateAppointmentButton);
            this.Controls.Add(this.InputAppointmentDateTime);
            this.Controls.Add(this.SaveCustomerAppointmentButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputCustomerAppointmentType);
            this.Controls.Add(this.InputCustomerNameAppoinment);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputCustomerNameAppoinment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button SaveCustomerAppointmentButton;
        private System.Windows.Forms.Button CancelCreateAppointmentButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        public System.Windows.Forms.DateTimePicker InputAppointmentDateTime;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker InputAppointmentEndTime;
        private System.Windows.Forms.TextBox InputCustomerAppointmentType;
    }
}