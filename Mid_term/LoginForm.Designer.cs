using System.Drawing;
using System.Windows.Forms;

namespace Mid_term
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.buttonTogglePassword = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRegisterName = new System.Windows.Forms.TextBox();
            this.textBoxRegisterEmail = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPhone = new System.Windows.Forms.TextBox();
            this.textBoxRegisterAddress = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegisterSalary = new System.Windows.Forms.TextBox();
            this.dateTimePickerRegisterHireDate = new System.Windows.Forms.DateTimePicker();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonShowRegister = new System.Windows.Forms.Button();
            this.buttonTogglePassword_1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUsername.Location = new System.Drawing.Point(198, 52);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(190, 33);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(198, 94);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(191, 33);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(199, 141);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(190, 29);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegister.Controls.Add(this.buttonTogglePassword);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.label2);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Controls.Add(this.textBoxRegisterName);
            this.panelRegister.Controls.Add(this.textBoxRegisterEmail);
            this.panelRegister.Controls.Add(this.textBoxRegisterPhone);
            this.panelRegister.Controls.Add(this.textBoxRegisterAddress);
            this.panelRegister.Controls.Add(this.textBoxRegisterPassword);
            this.panelRegister.Controls.Add(this.textBoxRegisterSalary);
            this.panelRegister.Controls.Add(this.dateTimePickerRegisterHireDate);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(2);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(543, 285);
            this.panelRegister.TabIndex = 4;
            this.panelRegister.Visible = false;
            // 
            // buttonTogglePassword
            // 
            this.buttonTogglePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTogglePassword.Location = new System.Drawing.Point(412, 147);
            this.buttonTogglePassword.Name = "buttonTogglePassword";
            this.buttonTogglePassword.Size = new System.Drawing.Size(50, 23);
            this.buttonTogglePassword.TabIndex = 14;
            this.buttonTogglePassword.Text = "Show";
            this.buttonTogglePassword.UseVisualStyleBackColor = true;
            this.buttonTogglePassword.Click += new System.EventHandler(this.buttonTogglePassword_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(126, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(102, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(112, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(126, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(134, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(134, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // textBoxRegisterName
            // 
            this.textBoxRegisterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegisterName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterName.Location = new System.Drawing.Point(196, 21);
            this.textBoxRegisterName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegisterName.Multiline = true;
            this.textBoxRegisterName.Name = "textBoxRegisterName";
            this.textBoxRegisterName.Size = new System.Drawing.Size(211, 27);
            this.textBoxRegisterName.TabIndex = 0;
            // 
            // textBoxRegisterEmail
            // 
            this.textBoxRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegisterEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterEmail.Location = new System.Drawing.Point(196, 52);
            this.textBoxRegisterEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegisterEmail.Multiline = true;
            this.textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            this.textBoxRegisterEmail.Size = new System.Drawing.Size(211, 27);
            this.textBoxRegisterEmail.TabIndex = 1;
            // 
            // textBoxRegisterPhone
            // 
            this.textBoxRegisterPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegisterPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterPhone.Location = new System.Drawing.Point(196, 83);
            this.textBoxRegisterPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegisterPhone.Multiline = true;
            this.textBoxRegisterPhone.Name = "textBoxRegisterPhone";
            this.textBoxRegisterPhone.Size = new System.Drawing.Size(211, 27);
            this.textBoxRegisterPhone.TabIndex = 2;
            // 
            // textBoxRegisterAddress
            // 
            this.textBoxRegisterAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegisterAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterAddress.Location = new System.Drawing.Point(196, 115);
            this.textBoxRegisterAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegisterAddress.Multiline = true;
            this.textBoxRegisterAddress.Name = "textBoxRegisterAddress";
            this.textBoxRegisterAddress.Size = new System.Drawing.Size(211, 27);
            this.textBoxRegisterAddress.TabIndex = 3;
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegisterPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(196, 146);
            this.textBoxRegisterPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegisterPassword.Multiline = true;
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '*';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(211, 27);
            this.textBoxRegisterPassword.TabIndex = 4;
            // 
            // textBoxRegisterSalary
            // 
            this.textBoxRegisterSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegisterSalary.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterSalary.Location = new System.Drawing.Point(196, 177);
            this.textBoxRegisterSalary.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegisterSalary.Multiline = true;
            this.textBoxRegisterSalary.Name = "textBoxRegisterSalary";
            this.textBoxRegisterSalary.Size = new System.Drawing.Size(211, 27);
            this.textBoxRegisterSalary.TabIndex = 5;
            // 
            // dateTimePickerRegisterHireDate
            // 
            this.dateTimePickerRegisterHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRegisterHireDate.Location = new System.Drawing.Point(196, 208);
            this.dateTimePickerRegisterHireDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerRegisterHireDate.Name = "dateTimePickerRegisterHireDate";
            this.dateTimePickerRegisterHireDate.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerRegisterHireDate.TabIndex = 6;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(196, 232);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(211, 30);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonShowRegister
            // 
            this.buttonShowRegister.Location = new System.Drawing.Point(198, 177);
            this.buttonShowRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowRegister.Name = "buttonShowRegister";
            this.buttonShowRegister.Size = new System.Drawing.Size(55, 33);
            this.buttonShowRegister.TabIndex = 3;
            this.buttonShowRegister.Text = "Register";
            this.buttonShowRegister.UseVisualStyleBackColor = true;
            this.buttonShowRegister.Click += new System.EventHandler(this.buttonShowRegister_Click);
            // 
            // buttonTogglePassword_1
            // 
            this.buttonTogglePassword_1.Location = new System.Drawing.Point(394, 94);
            this.buttonTogglePassword_1.Name = "buttonTogglePassword_1";
            this.buttonTogglePassword_1.Size = new System.Drawing.Size(44, 33);
            this.buttonTogglePassword_1.TabIndex = 5;
            this.buttonTogglePassword_1.Text = "Show";
            this.buttonTogglePassword_1.UseVisualStyleBackColor = true;
            this.buttonTogglePassword_1.Click += new System.EventHandler(this.buttonTogglePassword_1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(139, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 284);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.buttonShowRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonTogglePassword_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Pi Store Management";
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.TextBox textBoxRegisterName;
        private System.Windows.Forms.TextBox textBoxRegisterEmail;
        private System.Windows.Forms.TextBox textBoxRegisterPhone;
        private System.Windows.Forms.TextBox textBoxRegisterAddress;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterSalary;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegisterHireDate;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonShowRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTogglePassword;
        private System.Windows.Forms.Button buttonTogglePassword_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

