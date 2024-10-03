namespace Mid_term
{
    partial class PlaceOrder
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
            this.labelSelectClient = new System.Windows.Forms.Label();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.listBoxSelectedProducts = new System.Windows.Forms.ListBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.buttonSubmitOrder = new System.Windows.Forms.Button();
            this.buttonClearSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectClient
            // 
            this.labelSelectClient.AutoSize = true;
            this.labelSelectClient.Location = new System.Drawing.Point(20, 20);
            this.labelSelectClient.Name = "labelSelectClient";
            this.labelSelectClient.Size = new System.Drawing.Size(69, 13);
            this.labelSelectClient.TabIndex = 0;
            this.labelSelectClient.Text = "Select Client:";
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(100, 20);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(250, 21);
            this.comboBoxClients.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewProducts.TabIndex = 2;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick_1);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(550, 60);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(100, 23);
            this.buttonAddProduct.TabIndex = 3;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // listBoxSelectedProducts
            // 
            this.listBoxSelectedProducts.FormattingEnabled = true;
            this.listBoxSelectedProducts.Location = new System.Drawing.Point(550, 100);
            this.listBoxSelectedProducts.Name = "listBoxSelectedProducts";
            this.listBoxSelectedProducts.Size = new System.Drawing.Size(200, 160);
            this.listBoxSelectedProducts.TabIndex = 4;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(20, 280);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(61, 13);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "Total Price:";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Enabled = false;
            this.textBoxTotalPrice.Location = new System.Drawing.Point(100, 280);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalPrice.TabIndex = 6;
            // 
            // buttonSubmitOrder
            // 
            this.buttonSubmitOrder.Location = new System.Drawing.Point(20, 320);
            this.buttonSubmitOrder.Name = "buttonSubmitOrder";
            this.buttonSubmitOrder.Size = new System.Drawing.Size(100, 23);
            this.buttonSubmitOrder.TabIndex = 7;
            this.buttonSubmitOrder.Text = "Submit Order";
            this.buttonSubmitOrder.UseVisualStyleBackColor = true;
            this.buttonSubmitOrder.Click += new System.EventHandler(this.buttonSubmitOrder_Click);
            // 
            // buttonClearSelection
            // 
            this.buttonClearSelection.Location = new System.Drawing.Point(550, 280);
            this.buttonClearSelection.Name = "buttonClearSelection";
            this.buttonClearSelection.Size = new System.Drawing.Size(100, 23);
            this.buttonClearSelection.TabIndex = 8;
            this.buttonClearSelection.Text = "Clear Selection";
            this.buttonClearSelection.UseVisualStyleBackColor = true;
            this.buttonClearSelection.Click += new System.EventHandler(this.buttonClearSelection_Click);
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.buttonClearSelection);
            this.Controls.Add(this.buttonSubmitOrder);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.listBoxSelectedProducts);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.labelSelectClient);
            this.Name = "PlaceOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Place Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSelectClient;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ListBox listBoxSelectedProducts;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Button buttonSubmitOrder;
        private System.Windows.Forms.Button buttonClearSelection;
    }
}