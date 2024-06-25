namespace C969MatthewSmith.Forms.UpdateAppointment
{
    partial class UpdateAppointmentForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.CancelCreateAppointmentButton = new System.Windows.Forms.Button();
            this.InputAppointmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.InputUserIdAppointment = new System.Windows.Forms.TextBox();
            this.SaveCustomerAppointmentButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InputCustomerAppointmentType = new System.Windows.Forms.TextBox();
            this.InputCustomerNameAppoinment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InputAppointmentCustomerId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InputAppointmentEndTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Update Appointment";
            // 
            // CancelCreateAppointmentButton
            // 
            this.CancelCreateAppointmentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelCreateAppointmentButton.Location = new System.Drawing.Point(556, 1067);
            this.CancelCreateAppointmentButton.Name = "CancelCreateAppointmentButton";
            this.CancelCreateAppointmentButton.Size = new System.Drawing.Size(291, 81);
            this.CancelCreateAppointmentButton.TabIndex = 24;
            this.CancelCreateAppointmentButton.Text = "Cancel";
            this.CancelCreateAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // InputAppointmentDateTime
            // 
            this.InputAppointmentDateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAppointmentDateTime.Location = new System.Drawing.Point(189, 653);
            this.InputAppointmentDateTime.Name = "InputAppointmentDateTime";
            this.InputAppointmentDateTime.Size = new System.Drawing.Size(656, 27);
            this.InputAppointmentDateTime.TabIndex = 23;
            // 
            // InputUserIdAppointment
            // 
            this.InputUserIdAppointment.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUserIdAppointment.Location = new System.Drawing.Point(189, 972);
            this.InputUserIdAppointment.Name = "InputUserIdAppointment";
            this.InputUserIdAppointment.ReadOnly = true;
            this.InputUserIdAppointment.Size = new System.Drawing.Size(656, 27);
            this.InputUserIdAppointment.TabIndex = 22;
            // 
            // SaveCustomerAppointmentButton
            // 
            this.SaveCustomerAppointmentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCustomerAppointmentButton.Location = new System.Drawing.Point(189, 1067);
            this.SaveCustomerAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveCustomerAppointmentButton.Name = "SaveCustomerAppointmentButton";
            this.SaveCustomerAppointmentButton.Size = new System.Drawing.Size(291, 81);
            this.SaveCustomerAppointmentButton.TabIndex = 21;
            this.SaveCustomerAppointmentButton.Text = "Save";
            this.SaveCustomerAppointmentButton.UseVisualStyleBackColor = true;
            this.SaveCustomerAppointmentButton.Click += new System.EventHandler(this.SaveCustomerAppointmentButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 577);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 419);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer name";
            // 
            // InputCustomerAppointmentType
            // 
            this.InputCustomerAppointmentType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCustomerAppointmentType.Location = new System.Drawing.Point(189, 172);
            this.InputCustomerAppointmentType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputCustomerAppointmentType.Name = "InputCustomerAppointmentType";
            this.InputCustomerAppointmentType.Size = new System.Drawing.Size(656, 27);
            this.InputCustomerAppointmentType.TabIndex = 17;
            // 
            // InputCustomerNameAppoinment
            // 
            this.InputCustomerNameAppoinment.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCustomerNameAppoinment.Location = new System.Drawing.Point(189, 489);
            this.InputCustomerNameAppoinment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputCustomerNameAppoinment.Name = "InputCustomerNameAppoinment";
            this.InputCustomerNameAppoinment.Size = new System.Drawing.Size(656, 27);
            this.InputCustomerNameAppoinment.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 894);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "User ID";
            // 
            // InputAppointmentCustomerId
            // 
            this.InputAppointmentCustomerId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAppointmentCustomerId.Location = new System.Drawing.Point(189, 317);
            this.InputAppointmentCustomerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputAppointmentCustomerId.Name = "InputAppointmentCustomerId";
            this.InputAppointmentCustomerId.ReadOnly = true;
            this.InputAppointmentCustomerId.Size = new System.Drawing.Size(656, 27);
            this.InputAppointmentCustomerId.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Customer ID";
            // 
            // InputAppointmentEndTime
            // 
            this.InputAppointmentEndTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAppointmentEndTime.Location = new System.Drawing.Point(189, 805);
            this.InputAppointmentEndTime.Name = "InputAppointmentEndTime";
            this.InputAppointmentEndTime.Size = new System.Drawing.Size(656, 27);
            this.InputAppointmentEndTime.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 734);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "End";
            // 
            // UpdateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 1227);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InputAppointmentEndTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InputAppointmentCustomerId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelCreateAppointmentButton);
            this.Controls.Add(this.InputAppointmentDateTime);
            this.Controls.Add(this.InputUserIdAppointment);
            this.Controls.Add(this.SaveCustomerAppointmentButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputCustomerAppointmentType);
            this.Controls.Add(this.InputCustomerNameAppoinment);
            this.Name = "UpdateAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelCreateAppointmentButton;
        private System.Windows.Forms.DateTimePicker InputAppointmentDateTime;
        private System.Windows.Forms.TextBox InputUserIdAppointment;
        public System.Windows.Forms.Button SaveCustomerAppointmentButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputCustomerAppointmentType;
        private System.Windows.Forms.TextBox InputCustomerNameAppoinment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputAppointmentCustomerId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker InputAppointmentEndTime;
        private System.Windows.Forms.Label label7;
    }
}