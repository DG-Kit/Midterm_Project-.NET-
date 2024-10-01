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
            this.labelReturnLogin = new System.Windows.Forms.Label();
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTogglePassword_1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.Location = new System.Drawing.Point(536, 228);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(223, 29);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.Location = new System.Drawing.Point(536, 266);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(223, 30);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(540, 308);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(219, 48);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.SystemColors.Window;
            this.panelRegister.Controls.Add(this.labelReturnLogin);
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
            this.panelRegister.Controls.Add(this.pictureBox3);
            this.panelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelRegister.Location = new System.Drawing.Point(-3, 0);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(2);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(865, 532);
            this.panelRegister.TabIndex = 4;
            this.panelRegister.Visible = false;
            // 
            // labelReturnLogin
            // 
            this.labelReturnLogin.AutoSize = true;
            this.labelReturnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReturnLogin.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelReturnLogin.Location = new System.Drawing.Point(152, 408);
            this.labelReturnLogin.Name = "labelReturnLogin";
            this.labelReturnLogin.Size = new System.Drawing.Size(122, 18);
            this.labelReturnLogin.TabIndex = 16;
            this.labelReturnLogin.Text = "Return to Login";
            this.labelReturnLogin.Click += new System.EventHandler(this.labelReturnLogin_Click);
            this.labelReturnLogin.MouseEnter += new System.EventHandler(this.labelReturnLogin_MouseEnter);
            this.labelReturnLogin.MouseLeave += new System.EventHandler(this.labelReturnLogin_MouseLeave);
            // 
            // buttonTogglePassword
            // 
            this.buttonTogglePassword.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTogglePassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonTogglePassword.Image")));
            this.buttonTogglePassword.Location = new System.Drawing.Point(371, 273);
            this.buttonTogglePassword.Name = "buttonTogglePassword";
            this.buttonTogglePassword.Size = new System.Drawing.Size(31, 26);
            this.buttonTogglePassword.TabIndex = 14;
            this.buttonTogglePassword.UseVisualStyleBackColor = true;
            this.buttonTogglePassword.Click += new System.EventHandler(this.buttonTogglePassword_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // textBoxRegisterName
            // 
            this.textBoxRegisterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegisterName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterName.Location = new System.Drawing.Point(155, 147);
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
            this.textBoxRegisterEmail.Location = new System.Drawing.Point(155, 178);
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
            this.textBoxRegisterPhone.Location = new System.Drawing.Point(155, 209);
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
            this.textBoxRegisterAddress.Location = new System.Drawing.Point(155, 241);
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
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(155, 272);
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
            this.textBoxRegisterSalary.Location = new System.Drawing.Point(155, 303);
            this.textBoxRegisterSalary.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegisterSalary.Multiline = true;
            this.textBoxRegisterSalary.Name = "textBoxRegisterSalary";
            this.textBoxRegisterSalary.Size = new System.Drawing.Size(211, 27);
            this.textBoxRegisterSalary.TabIndex = 5;
            // 
            // dateTimePickerRegisterHireDate
            // 
            this.dateTimePickerRegisterHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRegisterHireDate.Location = new System.Drawing.Point(155, 334);
            this.dateTimePickerRegisterHireDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerRegisterHireDate.Name = "dateTimePickerRegisterHireDate";
            this.dateTimePickerRegisterHireDate.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerRegisterHireDate.TabIndex = 6;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(155, 365);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(211, 30);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(43, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(823, 529);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(553, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "New User? ";
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.BackColor = System.Drawing.SystemColors.Window;
            this.labelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegister.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRegister.Location = new System.Drawing.Point(635, 365);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(71, 18);
            this.labelRegister.TabIndex = 19;
            this.labelRegister.Text = "Register";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            this.labelRegister.MouseEnter += new System.EventHandler(this.labelRegister_MouseEnter);
            this.labelRegister.MouseLeave += new System.EventHandler(this.labelRegister_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(712, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Here";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(499, 266);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(499, 228);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 29);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(597, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 68);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTogglePassword_1
            // 
            this.buttonTogglePassword_1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTogglePassword_1.Image = ((System.Drawing.Image)(resources.GetObject("buttonTogglePassword_1.Image")));
            this.buttonTogglePassword_1.Location = new System.Drawing.Point(764, 266);
            this.buttonTogglePassword_1.Name = "buttonTogglePassword_1";
            this.buttonTogglePassword_1.Size = new System.Drawing.Size(42, 30);
            this.buttonTogglePassword_1.TabIndex = 5;
            this.buttonTogglePassword_1.UseVisualStyleBackColor = true;
            this.buttonTogglePassword_1.Click += new System.EventHandler(this.buttonTogglePassword_1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(730, 532);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(863, 532);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonTogglePassword_1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Pi Store Management";
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTogglePassword;
        private System.Windows.Forms.Button buttonTogglePassword_1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label7;
        private Label labelRegister;
        private Label label9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label labelReturnLogin;
    }
}

