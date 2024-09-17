namespace Mid_term
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonManageEmployees = new System.Windows.Forms.Button();
            this.buttonManageClients = new System.Windows.Forms.Button();
            this.buttonManageProducts = new System.Windows.Forms.Button();
            this.buttonPlaceOrders = new System.Windows.Forms.Button();
            this.buttonManageOrders = new System.Windows.Forms.Button();
            this.buttonGenerateBills = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageEmployees
            // 
            this.buttonManageEmployees.Location = new System.Drawing.Point(53, 54);
            this.buttonManageEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManageEmployees.Name = "buttonManageEmployees";
            this.buttonManageEmployees.Size = new System.Drawing.Size(150, 24);
            this.buttonManageEmployees.TabIndex = 0;
            this.buttonManageEmployees.Text = "Manage Employees";
            this.buttonManageEmployees.UseVisualStyleBackColor = true;
            this.buttonManageEmployees.Click += new System.EventHandler(this.buttonManageEmployees_Click);
            // 
            // buttonManageClients
            // 
            this.buttonManageClients.Location = new System.Drawing.Point(53, 87);
            this.buttonManageClients.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManageClients.Name = "buttonManageClients";
            this.buttonManageClients.Size = new System.Drawing.Size(150, 24);
            this.buttonManageClients.TabIndex = 1;
            this.buttonManageClients.Text = "Manage Clients";
            this.buttonManageClients.UseVisualStyleBackColor = true;
            this.buttonManageClients.Click += new System.EventHandler(this.buttonManageClients_Click);
            // 
            // buttonManageProducts
            // 
            this.buttonManageProducts.Location = new System.Drawing.Point(53, 119);
            this.buttonManageProducts.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManageProducts.Name = "buttonManageProducts";
            this.buttonManageProducts.Size = new System.Drawing.Size(150, 24);
            this.buttonManageProducts.TabIndex = 2;
            this.buttonManageProducts.Text = "Manage Products";
            this.buttonManageProducts.UseVisualStyleBackColor = true;
            // 
            // buttonPlaceOrders
            // 
            this.buttonPlaceOrders.Location = new System.Drawing.Point(53, 152);
            this.buttonPlaceOrders.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlaceOrders.Name = "buttonPlaceOrders";
            this.buttonPlaceOrders.Size = new System.Drawing.Size(150, 24);
            this.buttonPlaceOrders.TabIndex = 3;
            this.buttonPlaceOrders.Text = "Place Orders";
            this.buttonPlaceOrders.UseVisualStyleBackColor = true;
            // 
            // buttonManageOrders
            // 
            this.buttonManageOrders.Location = new System.Drawing.Point(53, 184);
            this.buttonManageOrders.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManageOrders.Name = "buttonManageOrders";
            this.buttonManageOrders.Size = new System.Drawing.Size(150, 24);
            this.buttonManageOrders.TabIndex = 4;
            this.buttonManageOrders.Text = "Manage Orders";
            this.buttonManageOrders.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateBills
            // 
            this.buttonGenerateBills.Location = new System.Drawing.Point(53, 217);
            this.buttonGenerateBills.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateBills.Name = "buttonGenerateBills";
            this.buttonGenerateBills.Size = new System.Drawing.Size(150, 24);
            this.buttonGenerateBills.TabIndex = 5;
            this.buttonGenerateBills.Text = "Generate Bills";
            this.buttonGenerateBills.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(168, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 288);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonGenerateBills);
            this.Controls.Add(this.buttonManageOrders);
            this.Controls.Add(this.buttonPlaceOrders);
            this.Controls.Add(this.buttonManageProducts);
            this.Controls.Add(this.buttonManageClients);
            this.Controls.Add(this.buttonManageEmployees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageEmployees;
        private System.Windows.Forms.Button buttonManageClients;
        private System.Windows.Forms.Button buttonManageProducts;
        private System.Windows.Forms.Button buttonPlaceOrders;
        private System.Windows.Forms.Button buttonManageOrders;
        private System.Windows.Forms.Button buttonGenerateBills;
        private System.Windows.Forms.Button buttonLogout;
    }
}