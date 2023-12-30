namespace InventoryManager
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInventory = new Label();
            lblParts = new Label();
            dgvParts = new DataGridView();
            dgvProducts = new DataGridView();
            lblProducts = new Label();
            btnSearchParts = new Button();
            txtSearchParts = new TextBox();
            txtSearchProducts = new TextBox();
            btnSearchProducts = new Button();
            btnModifyPart = new Button();
            btnAddPart = new Button();
            btnDeletePart = new Button();
            btnDeleteProduct = new Button();
            btnAddProduct = new Button();
            btnModifyProduct = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(17, 15);
            lblInventory.Margin = new Padding(4, 0, 4, 0);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(259, 25);
            lblInventory.TabIndex = 0;
            lblInventory.Text = "Inventory Management System";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(17, 103);
            lblParts.Margin = new Padding(4, 0, 4, 0);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(50, 25);
            lblParts.TabIndex = 1;
            lblParts.Text = "Parts";
            // 
            // dgvParts
            // 
            dgvParts.AllowUserToAddRows = false;
            dgvParts.AllowUserToDeleteRows = false;
            dgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParts.Location = new Point(17, 155);
            dgvParts.Margin = new Padding(4, 5, 4, 5);
            dgvParts.MultiSelect = false;
            dgvParts.Name = "dgvParts";
            dgvParts.ReadOnly = true;
            dgvParts.RowHeadersWidth = 62;
            dgvParts.RowTemplate.Height = 25;
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParts.Size = new Size(701, 597);
            dgvParts.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(769, 155);
            dgvProducts.Margin = new Padding(4, 5, 4, 5);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(693, 597);
            dgvProducts.TabIndex = 3;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(769, 103);
            lblProducts.Margin = new Padding(4, 0, 4, 0);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(82, 25);
            lblProducts.TabIndex = 4;
            lblProducts.Text = "Products";
            // 
            // btnSearchParts
            // 
            btnSearchParts.Location = new Point(399, 94);
            btnSearchParts.Margin = new Padding(4, 5, 4, 5);
            btnSearchParts.Name = "btnSearchParts";
            btnSearchParts.Size = new Size(107, 38);
            btnSearchParts.TabIndex = 5;
            btnSearchParts.Text = "Search";
            btnSearchParts.UseVisualStyleBackColor = true;
            btnSearchParts.Click += btnSearchParts_Click;
            // 
            // txtSearchParts
            // 
            txtSearchParts.Location = new Point(514, 98);
            txtSearchParts.Margin = new Padding(4, 5, 4, 5);
            txtSearchParts.Name = "txtSearchParts";
            txtSearchParts.Size = new Size(203, 31);
            txtSearchParts.TabIndex = 6;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Location = new Point(1257, 98);
            txtSearchProducts.Margin = new Padding(4, 5, 4, 5);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.Size = new Size(203, 31);
            txtSearchProducts.TabIndex = 8;
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.Location = new Point(1142, 94);
            btnSearchProducts.Margin = new Padding(4, 5, 4, 5);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(107, 38);
            btnSearchProducts.TabIndex = 7;
            btnSearchProducts.Text = "Search";
            btnSearchProducts.UseVisualStyleBackColor = true;
            btnSearchProducts.Click += btnSearchProducts_Click;
            // 
            // btnModifyPart
            // 
            btnModifyPart.Location = new Point(496, 777);
            btnModifyPart.Margin = new Padding(4, 5, 4, 5);
            btnModifyPart.Name = "btnModifyPart";
            btnModifyPart.Size = new Size(107, 38);
            btnModifyPart.TabIndex = 9;
            btnModifyPart.Text = "Modify";
            btnModifyPart.UseVisualStyleBackColor = true;
            btnModifyPart.Click += btnModifyPart_Click;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(380, 777);
            btnAddPart.Margin = new Padding(4, 5, 4, 5);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(107, 38);
            btnAddPart.TabIndex = 10;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(611, 777);
            btnDeletePart.Margin = new Padding(4, 5, 4, 5);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(107, 38);
            btnDeletePart.TabIndex = 11;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            btnDeletePart.Click += btnDeletePart_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(1354, 777);
            btnDeleteProduct.Margin = new Padding(4, 5, 4, 5);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(107, 38);
            btnDeleteProduct.TabIndex = 14;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(1123, 777);
            btnAddProduct.Margin = new Padding(4, 5, 4, 5);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(107, 38);
            btnAddProduct.TabIndex = 13;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnModifyProduct
            // 
            btnModifyProduct.Location = new Point(1239, 777);
            btnModifyProduct.Margin = new Padding(4, 5, 4, 5);
            btnModifyProduct.Name = "btnModifyProduct";
            btnModifyProduct.Size = new Size(107, 38);
            btnModifyProduct.TabIndex = 12;
            btnModifyProduct.Text = "Modify";
            btnModifyProduct.UseVisualStyleBackColor = true;
            btnModifyProduct.Click += btnModifyProduct_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1354, 13);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 38);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 838);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1479, 65);
            panel1.TabIndex = 16;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 903);
            Controls.Add(panel1);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(btnModifyProduct);
            Controls.Add(btnDeletePart);
            Controls.Add(btnAddPart);
            Controls.Add(btnModifyPart);
            Controls.Add(txtSearchProducts);
            Controls.Add(btnSearchProducts);
            Controls.Add(txtSearchParts);
            Controls.Add(btnSearchParts);
            Controls.Add(lblProducts);
            Controls.Add(dgvProducts);
            Controls.Add(dgvParts);
            Controls.Add(lblParts);
            Controls.Add(lblInventory);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventory;
        private Label lblParts;
        private DataGridView dgvParts;
        private DataGridView dgvProducts;
        private Label lblProducts;
        private Button btnSearchParts;
        private TextBox txtSearchParts;
        private TextBox txtSearchProducts;
        private Button btnSearchProducts;
        private Button btnModifyPart;
        private Button btnAddPart;
        private Button btnDeletePart;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
        private Button btnModifyProduct;
        private Button btnExit;
        private Panel panel1;
    }
}