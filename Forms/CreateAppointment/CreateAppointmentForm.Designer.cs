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
            this.InputCustomerAppointmentType = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // InputCustomerNameAppoinment
            // 
            this.InputCustomerNameAppoinment.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCustomerNameAppoinment.Location = new System.Drawing.Point(77, 312);
            this.InputCustomerNameAppoinment.Name = "InputCustomerNameAppoinment";
            this.InputCustomerNameAppoinment.Size = new System.Drawing.Size(424, 32);
            this.InputCustomerNameAppoinment.TabIndex = 0;
            // 
            // InputCustomerAppointmentType
            // 
            this.InputCustomerAppointmentType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCustomerAppointmentType.Location = new System.Drawing.Point(77, 192);
            this.InputCustomerAppointmentType.Name = "InputCustomerAppointmentType";
            this.InputCustomerAppointmentType.Size = new System.Drawing.Size(424, 32);
            this.InputCustomerAppointmentType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start";
            // 
            // SaveCustomerAppointmentButton
            // 
            this.SaveCustomerAppointmentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCustomerAppointmentButton.Location = new System.Drawing.Point(52, 584);
            this.SaveCustomerAppointmentButton.Name = "SaveCustomerAppointmentButton";
            this.SaveCustomerAppointmentButton.Size = new System.Drawing.Size(192, 52);
            this.SaveCustomerAppointmentButton.TabIndex = 10;
            this.SaveCustomerAppointmentButton.Text = "Save";
            this.SaveCustomerAppointmentButton.UseVisualStyleBackColor = true;
            this.SaveCustomerAppointmentButton.Click += new System.EventHandler(this.SaveCustomerAppointmentButton_Click);
            // 
            // InputAppointmentDateTime
            // 
            this.InputAppointmentDateTime.CalendarFont = new System.Drawing.Font("Verdana", 14F);
            this.InputAppointmentDateTime.Font = new System.Drawing.Font("Verdana", 12F);
            this.InputAppointmentDateTime.Location = new System.Drawing.Point(77, 424);
            this.InputAppointmentDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.InputAppointmentDateTime.Name = "InputAppointmentDateTime";
            this.InputAppointmentDateTime.Size = new System.Drawing.Size(424, 32);
            this.InputAppointmentDateTime.TabIndex = 12;
            // 
            // CancelCreateAppointmentButton
            // 
            this.CancelCreateAppointmentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelCreateAppointmentButton.Location = new System.Drawing.Point(293, 584);
            this.CancelCreateAppointmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelCreateAppointmentButton.Name = "CancelCreateAppointmentButton";
            this.CancelCreateAppointmentButton.Size = new System.Drawing.Size(192, 52);
            this.CancelCreateAppointmentButton.TabIndex = 14;
            this.CancelCreateAppointmentButton.Text = "Cancel";
            this.CancelCreateAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
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
            this.label5.Location = new System.Drawing.Point(72, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "End";
            // 
            // InputAppointmentEndTime
            // 
            this.InputAppointmentEndTime.CalendarFont = new System.Drawing.Font("Verdana", 14F);
            this.InputAppointmentEndTime.Font = new System.Drawing.Font("Verdana", 12F);
            this.InputAppointmentEndTime.Location = new System.Drawing.Point(77, 513);
            this.InputAppointmentEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.InputAppointmentEndTime.Name = "InputAppointmentEndTime";
            this.InputAppointmentEndTime.Size = new System.Drawing.Size(424, 32);
            this.InputAppointmentEndTime.TabIndex = 17;
            this.InputAppointmentEndTime.Value = new System.DateTime(2024, 6, 2, 19, 2, 29, 0);
            // 
            // CreateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 700);
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
            this.Name = "CreateAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputCustomerNameAppoinment;
        private System.Windows.Forms.TextBox InputCustomerAppointmentType;
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
    }
}