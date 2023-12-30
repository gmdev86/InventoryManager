namespace InventoryManager
{
    partial class frmAddProduct
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
            btnCancel = new Button();
            pnlFooter = new Panel();
            btnSave = new Button();
            dgvAllParts = new DataGridView();
            dgvLinkedParts = new DataGridView();
            txtSearchParts = new TextBox();
            btnSearchParts = new Button();
            lblAllParts = new Label();
            lblLinkedParts = new Label();
            lblAddProduct = new Label();
            btnAddPart = new Button();
            btnDelete = new Button();
            lblMinValidation = new Label();
            lblMaxValidation = new Label();
            lblPriceCostValidation = new Label();
            lblInventoryValidation = new Label();
            lblNameValidation = new Label();
            txtPartId = new TextBox();
            txtName = new TextBox();
            txtInventory = new TextBox();
            txtPriceCost = new TextBox();
            txtMin = new TextBox();
            txtMax = new TextBox();
            lblMin = new Label();
            lblMax = new Label();
            lblPartId = new Label();
            lblPriceCost = new Label();
            lblName = new Label();
            lblInventory = new Label();
            pnlValidationErrors = new Panel();
            lblValidationErrors = new Label();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLinkedParts).BeginInit();
            pnlValidationErrors.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1408, 16);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFooter.BackColor = SystemColors.ActiveCaption;
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 917);
            pnlFooter.Margin = new Padding(0);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1528, 73);
            pnlFooter.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1266, 18);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 117;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvAllParts
            // 
            dgvAllParts.AllowUserToAddRows = false;
            dgvAllParts.AllowUserToDeleteRows = false;
            dgvAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllParts.Location = new Point(615, 119);
            dgvAllParts.MultiSelect = false;
            dgvAllParts.Name = "dgvAllParts";
            dgvAllParts.ReadOnly = true;
            dgvAllParts.RowHeadersWidth = 62;
            dgvAllParts.RowTemplate.Height = 33;
            dgvAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllParts.Size = new Size(900, 286);
            dgvAllParts.TabIndex = 2;
            // 
            // dgvLinkedParts
            // 
            dgvLinkedParts.AllowUserToAddRows = false;
            dgvLinkedParts.AllowUserToDeleteRows = false;
            dgvLinkedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLinkedParts.Location = new Point(615, 515);
            dgvLinkedParts.MultiSelect = false;
            dgvLinkedParts.Name = "dgvLinkedParts";
            dgvLinkedParts.ReadOnly = true;
            dgvLinkedParts.RowHeadersWidth = 62;
            dgvLinkedParts.RowTemplate.Height = 33;
            dgvLinkedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLinkedParts.Size = new Size(900, 309);
            dgvLinkedParts.TabIndex = 3;
            // 
            // txtSearchParts
            // 
            txtSearchParts.Location = new Point(1184, 56);
            txtSearchParts.Name = "txtSearchParts";
            txtSearchParts.Size = new Size(331, 31);
            txtSearchParts.TabIndex = 4;
            // 
            // btnSearchParts
            // 
            btnSearchParts.Location = new Point(1066, 54);
            btnSearchParts.Name = "btnSearchParts";
            btnSearchParts.Size = new Size(112, 34);
            btnSearchParts.TabIndex = 5;
            btnSearchParts.Text = "Search";
            btnSearchParts.UseVisualStyleBackColor = true;
            btnSearchParts.Click += btnSearchParts_Click;
            // 
            // lblAllParts
            // 
            lblAllParts.AutoSize = true;
            lblAllParts.Location = new Point(615, 79);
            lblAllParts.Name = "lblAllParts";
            lblAllParts.Size = new Size(157, 25);
            lblAllParts.TabIndex = 6;
            lblAllParts.Text = "All candidate Parts";
            // 
            // lblLinkedParts
            // 
            lblLinkedParts.AutoSize = true;
            lblLinkedParts.Location = new Point(615, 478);
            lblLinkedParts.Name = "lblLinkedParts";
            lblLinkedParts.Size = new Size(279, 25);
            lblLinkedParts.TabIndex = 7;
            lblLinkedParts.Text = "Parts Associated with this Product";
            // 
            // lblAddProduct
            // 
            lblAddProduct.AutoSize = true;
            lblAddProduct.Location = new Point(38, 39);
            lblAddProduct.Name = "lblAddProduct";
            lblAddProduct.Size = new Size(113, 25);
            lblAddProduct.TabIndex = 8;
            lblAddProduct.Text = "Add Product";
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(1403, 411);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(112, 34);
            btnAddPart.TabIndex = 9;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1403, 830);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblMinValidation
            // 
            lblMinValidation.AutoSize = true;
            lblMinValidation.BackColor = SystemColors.Control;
            lblMinValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMinValidation.ForeColor = Color.Red;
            lblMinValidation.Location = new Point(386, 599);
            lblMinValidation.Name = "lblMinValidation";
            lblMinValidation.Size = new Size(89, 25);
            lblMinValidation.TabIndex = 114;
            lblMinValidation.Text = "Required";
            lblMinValidation.Visible = false;
            // 
            // lblMaxValidation
            // 
            lblMaxValidation.AutoSize = true;
            lblMaxValidation.BackColor = SystemColors.Control;
            lblMaxValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaxValidation.ForeColor = Color.Red;
            lblMaxValidation.Location = new Point(131, 599);
            lblMaxValidation.Name = "lblMaxValidation";
            lblMaxValidation.Size = new Size(89, 25);
            lblMaxValidation.TabIndex = 113;
            lblMaxValidation.Text = "Required";
            lblMaxValidation.Visible = false;
            // 
            // lblPriceCostValidation
            // 
            lblPriceCostValidation.AutoSize = true;
            lblPriceCostValidation.BackColor = SystemColors.Control;
            lblPriceCostValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriceCostValidation.ForeColor = Color.Red;
            lblPriceCostValidation.Location = new Point(131, 514);
            lblPriceCostValidation.Name = "lblPriceCostValidation";
            lblPriceCostValidation.Size = new Size(89, 25);
            lblPriceCostValidation.TabIndex = 112;
            lblPriceCostValidation.Text = "Required";
            lblPriceCostValidation.Visible = false;
            // 
            // lblInventoryValidation
            // 
            lblInventoryValidation.AutoSize = true;
            lblInventoryValidation.BackColor = SystemColors.Control;
            lblInventoryValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInventoryValidation.ForeColor = Color.Red;
            lblInventoryValidation.Location = new Point(131, 439);
            lblInventoryValidation.Name = "lblInventoryValidation";
            lblInventoryValidation.Size = new Size(89, 25);
            lblInventoryValidation.TabIndex = 111;
            lblInventoryValidation.Text = "Required";
            lblInventoryValidation.Visible = false;
            // 
            // lblNameValidation
            // 
            lblNameValidation.AutoSize = true;
            lblNameValidation.BackColor = SystemColors.Control;
            lblNameValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameValidation.ForeColor = Color.Red;
            lblNameValidation.Location = new Point(131, 356);
            lblNameValidation.Name = "lblNameValidation";
            lblNameValidation.Size = new Size(89, 25);
            lblNameValidation.TabIndex = 110;
            lblNameValidation.Text = "Required";
            lblNameValidation.Visible = false;
            // 
            // txtPartId
            // 
            txtPartId.Enabled = false;
            txtPartId.Location = new Point(131, 245);
            txtPartId.Margin = new Padding(4, 5, 4, 5);
            txtPartId.Name = "txtPartId";
            txtPartId.Size = new Size(141, 31);
            txtPartId.TabIndex = 116;
            txtPartId.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 320);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 31);
            txtName.TabIndex = 101;
            txtName.Leave += txtName_Leave;
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(131, 403);
            txtInventory.Margin = new Padding(4, 5, 4, 5);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(141, 31);
            txtInventory.TabIndex = 103;
            txtInventory.Leave += txtInventory_Leave;
            // 
            // txtPriceCost
            // 
            txtPriceCost.Location = new Point(131, 478);
            txtPriceCost.Margin = new Padding(4, 5, 4, 5);
            txtPriceCost.Name = "txtPriceCost";
            txtPriceCost.Size = new Size(141, 31);
            txtPriceCost.TabIndex = 105;
            txtPriceCost.Leave += txtPriceCost_Leave;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(386, 563);
            txtMin.Margin = new Padding(4, 5, 4, 5);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(141, 31);
            txtMin.TabIndex = 108;
            txtMin.Leave += txtMin_Leave;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(131, 563);
            txtMax.Margin = new Padding(4, 5, 4, 5);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(141, 31);
            txtMax.TabIndex = 107;
            txtMax.Leave += txtMax_Leave;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(337, 568);
            lblMin.Margin = new Padding(4, 0, 4, 0);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(50, 25);
            lblMin.TabIndex = 109;
            lblMin.Text = "Min*";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(75, 568);
            lblMax.Margin = new Padding(4, 0, 4, 0);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(53, 25);
            lblMax.TabIndex = 106;
            lblMax.Text = "Max*";
            // 
            // lblPartId
            // 
            lblPartId.AutoSize = true;
            lblPartId.Location = new Point(99, 250);
            lblPartId.Margin = new Padding(4, 0, 4, 0);
            lblPartId.Name = "lblPartId";
            lblPartId.Size = new Size(28, 25);
            lblPartId.TabIndex = 115;
            lblPartId.Text = "Id";
            // 
            // lblPriceCost
            // 
            lblPriceCost.AutoSize = true;
            lblPriceCost.Location = new Point(19, 483);
            lblPriceCost.Margin = new Padding(4, 0, 4, 0);
            lblPriceCost.Name = "lblPriceCost";
            lblPriceCost.Size = new Size(110, 25);
            lblPriceCost.TabIndex = 104;
            lblPriceCost.Text = "Price / Cost*";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(59, 325);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 25);
            lblName.TabIndex = 100;
            lblName.Text = "Name*";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(34, 408);
            lblInventory.Margin = new Padding(4, 0, 4, 0);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(95, 25);
            lblInventory.TabIndex = 102;
            lblInventory.Text = "Inventory*";
            // 
            // pnlValidationErrors
            // 
            pnlValidationErrors.AutoSize = true;
            pnlValidationErrors.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlValidationErrors.Controls.Add(lblValidationErrors);
            pnlValidationErrors.Location = new Point(19, 119);
            pnlValidationErrors.Name = "pnlValidationErrors";
            pnlValidationErrors.Size = new Size(148, 35);
            pnlValidationErrors.TabIndex = 117;
            // 
            // lblValidationErrors
            // 
            lblValidationErrors.AutoSize = true;
            lblValidationErrors.ForeColor = Color.Red;
            lblValidationErrors.Location = new Point(9, 10);
            lblValidationErrors.Name = "lblValidationErrors";
            lblValidationErrors.Size = new Size(136, 25);
            lblValidationErrors.TabIndex = 118;
            lblValidationErrors.Text = "ValidationErrors";
            lblValidationErrors.Visible = false;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1528, 990);
            Controls.Add(pnlValidationErrors);
            Controls.Add(lblMinValidation);
            Controls.Add(lblMaxValidation);
            Controls.Add(lblPriceCostValidation);
            Controls.Add(lblInventoryValidation);
            Controls.Add(lblNameValidation);
            Controls.Add(txtPartId);
            Controls.Add(txtName);
            Controls.Add(txtInventory);
            Controls.Add(txtPriceCost);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Controls.Add(lblPartId);
            Controls.Add(lblPriceCost);
            Controls.Add(lblName);
            Controls.Add(lblInventory);
            Controls.Add(btnDelete);
            Controls.Add(btnAddPart);
            Controls.Add(lblAddProduct);
            Controls.Add(lblLinkedParts);
            Controls.Add(lblAllParts);
            Controls.Add(btnSearchParts);
            Controls.Add(txtSearchParts);
            Controls.Add(dgvLinkedParts);
            Controls.Add(dgvAllParts);
            Controls.Add(pnlFooter);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLinkedParts).EndInit();
            pnlValidationErrors.ResumeLayout(false);
            pnlValidationErrors.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Panel pnlFooter;
        private DataGridView dgvAllParts;
        private DataGridView dgvLinkedParts;
        private TextBox txtSearchParts;
        private Button btnSearchParts;
        private Label lblAllParts;
        private Label lblLinkedParts;
        private Label lblAddProduct;
        private Button btnAddPart;
        private Button btnDelete;
        private Label lblMinValidation;
        private Label lblMaxValidation;
        private Label lblPriceCostValidation;
        private Label lblInventoryValidation;
        private Label lblNameValidation;
        private TextBox txtPartId;
        private TextBox txtName;
        private TextBox txtInventory;
        private TextBox txtPriceCost;
        private TextBox txtMin;
        private TextBox txtMax;
        private Label lblMin;
        private Label lblMax;
        private Label lblPartId;
        private Label lblPriceCost;
        private Label lblName;
        private Label lblInventory;
        private Button btnSave;
        private Panel pnlValidationErrors;
        private Label lblValidationErrors;
    }
}