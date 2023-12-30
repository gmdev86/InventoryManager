namespace InventoryManager
{
    partial class frmModifyProduct
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
            lblValidationErrors = new Label();
            pnlValidationErrors = new Panel();
            lblMinValidation = new Label();
            lblMaxValidation = new Label();
            lblPriceCostValidation = new Label();
            lblInventoryValidation = new Label();
            btnCancel = new Button();
            lblNameValidation = new Label();
            txtProductId = new TextBox();
            btnSave = new Button();
            txtName = new TextBox();
            txtInventory = new TextBox();
            txtPriceCost = new TextBox();
            txtMin = new TextBox();
            txtMax = new TextBox();
            lblMin = new Label();
            lblMax = new Label();
            lblProductId = new Label();
            lblPriceCost = new Label();
            lblName = new Label();
            lblInventory = new Label();
            btnDelete = new Button();
            btnAddPart = new Button();
            lblModifyProduct = new Label();
            lblLinkedParts = new Label();
            lblAllParts = new Label();
            btnSearchParts = new Button();
            txtSearchParts = new TextBox();
            dgvLinkedParts = new DataGridView();
            dgvAllParts = new DataGridView();
            pnlFooter = new Panel();
            pnlValidationErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLinkedParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
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
            // pnlValidationErrors
            // 
            pnlValidationErrors.AutoSize = true;
            pnlValidationErrors.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlValidationErrors.Controls.Add(lblValidationErrors);
            pnlValidationErrors.Location = new Point(19, 100);
            pnlValidationErrors.Name = "pnlValidationErrors";
            pnlValidationErrors.Size = new Size(148, 35);
            pnlValidationErrors.TabIndex = 145;
            // 
            // lblMinValidation
            // 
            lblMinValidation.AutoSize = true;
            lblMinValidation.BackColor = SystemColors.Control;
            lblMinValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMinValidation.ForeColor = Color.Red;
            lblMinValidation.Location = new Point(386, 580);
            lblMinValidation.Name = "lblMinValidation";
            lblMinValidation.Size = new Size(89, 25);
            lblMinValidation.TabIndex = 142;
            lblMinValidation.Text = "Required";
            lblMinValidation.Visible = false;
            // 
            // lblMaxValidation
            // 
            lblMaxValidation.AutoSize = true;
            lblMaxValidation.BackColor = SystemColors.Control;
            lblMaxValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaxValidation.ForeColor = Color.Red;
            lblMaxValidation.Location = new Point(131, 580);
            lblMaxValidation.Name = "lblMaxValidation";
            lblMaxValidation.Size = new Size(89, 25);
            lblMaxValidation.TabIndex = 141;
            lblMaxValidation.Text = "Required";
            lblMaxValidation.Visible = false;
            // 
            // lblPriceCostValidation
            // 
            lblPriceCostValidation.AutoSize = true;
            lblPriceCostValidation.BackColor = SystemColors.Control;
            lblPriceCostValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriceCostValidation.ForeColor = Color.Red;
            lblPriceCostValidation.Location = new Point(131, 495);
            lblPriceCostValidation.Name = "lblPriceCostValidation";
            lblPriceCostValidation.Size = new Size(89, 25);
            lblPriceCostValidation.TabIndex = 140;
            lblPriceCostValidation.Text = "Required";
            lblPriceCostValidation.Visible = false;
            // 
            // lblInventoryValidation
            // 
            lblInventoryValidation.AutoSize = true;
            lblInventoryValidation.BackColor = SystemColors.Control;
            lblInventoryValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInventoryValidation.ForeColor = Color.Red;
            lblInventoryValidation.Location = new Point(131, 420);
            lblInventoryValidation.Name = "lblInventoryValidation";
            lblInventoryValidation.Size = new Size(89, 25);
            lblInventoryValidation.TabIndex = 139;
            lblInventoryValidation.Text = "Required";
            lblInventoryValidation.Visible = false;
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
            // lblNameValidation
            // 
            lblNameValidation.AutoSize = true;
            lblNameValidation.BackColor = SystemColors.Control;
            lblNameValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameValidation.ForeColor = Color.Red;
            lblNameValidation.Location = new Point(131, 337);
            lblNameValidation.Name = "lblNameValidation";
            lblNameValidation.Size = new Size(89, 25);
            lblNameValidation.TabIndex = 138;
            lblNameValidation.Text = "Required";
            lblNameValidation.Visible = false;
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new Point(131, 226);
            txtProductId.Margin = new Padding(4, 5, 4, 5);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(141, 31);
            txtProductId.TabIndex = 144;
            txtProductId.TabStop = false;
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
            // txtName
            // 
            txtName.Location = new Point(131, 301);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 31);
            txtName.TabIndex = 129;
            txtName.Leave += txtName_Leave;
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(131, 384);
            txtInventory.Margin = new Padding(4, 5, 4, 5);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(141, 31);
            txtInventory.TabIndex = 131;
            txtInventory.Leave += txtInventory_Leave;
            // 
            // txtPriceCost
            // 
            txtPriceCost.Location = new Point(131, 459);
            txtPriceCost.Margin = new Padding(4, 5, 4, 5);
            txtPriceCost.Name = "txtPriceCost";
            txtPriceCost.Size = new Size(141, 31);
            txtPriceCost.TabIndex = 133;
            txtPriceCost.Leave += txtPriceCost_Leave;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(386, 544);
            txtMin.Margin = new Padding(4, 5, 4, 5);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(141, 31);
            txtMin.TabIndex = 136;
            txtMin.Leave += txtMin_Leave;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(131, 544);
            txtMax.Margin = new Padding(4, 5, 4, 5);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(141, 31);
            txtMax.TabIndex = 135;
            txtMax.Leave += txtMax_Leave;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(337, 549);
            lblMin.Margin = new Padding(4, 0, 4, 0);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(50, 25);
            lblMin.TabIndex = 137;
            lblMin.Text = "Min*";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(75, 549);
            lblMax.Margin = new Padding(4, 0, 4, 0);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(53, 25);
            lblMax.TabIndex = 134;
            lblMax.Text = "Max*";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(99, 231);
            lblProductId.Margin = new Padding(4, 0, 4, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(28, 25);
            lblProductId.TabIndex = 143;
            lblProductId.Text = "Id";
            // 
            // lblPriceCost
            // 
            lblPriceCost.AutoSize = true;
            lblPriceCost.Location = new Point(19, 464);
            lblPriceCost.Margin = new Padding(4, 0, 4, 0);
            lblPriceCost.Name = "lblPriceCost";
            lblPriceCost.Size = new Size(110, 25);
            lblPriceCost.TabIndex = 132;
            lblPriceCost.Text = "Price / Cost*";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(59, 306);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 25);
            lblName.TabIndex = 128;
            lblName.Text = "Name*";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(34, 389);
            lblInventory.Margin = new Padding(4, 0, 4, 0);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(95, 25);
            lblInventory.TabIndex = 130;
            lblInventory.Text = "Inventory*";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1403, 811);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 127;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(1403, 392);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(112, 34);
            btnAddPart.TabIndex = 126;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // lblModifyProduct
            // 
            lblModifyProduct.AutoSize = true;
            lblModifyProduct.Location = new Point(38, 20);
            lblModifyProduct.Name = "lblModifyProduct";
            lblModifyProduct.Size = new Size(136, 25);
            lblModifyProduct.TabIndex = 125;
            lblModifyProduct.Text = "Modify Product";
            // 
            // lblLinkedParts
            // 
            lblLinkedParts.AutoSize = true;
            lblLinkedParts.Location = new Point(615, 459);
            lblLinkedParts.Name = "lblLinkedParts";
            lblLinkedParts.Size = new Size(279, 25);
            lblLinkedParts.TabIndex = 124;
            lblLinkedParts.Text = "Parts Associated with this Product";
            // 
            // lblAllParts
            // 
            lblAllParts.AutoSize = true;
            lblAllParts.Location = new Point(615, 60);
            lblAllParts.Name = "lblAllParts";
            lblAllParts.Size = new Size(157, 25);
            lblAllParts.TabIndex = 123;
            lblAllParts.Text = "All candidate Parts";
            // 
            // btnSearchParts
            // 
            btnSearchParts.Location = new Point(1066, 35);
            btnSearchParts.Name = "btnSearchParts";
            btnSearchParts.Size = new Size(112, 34);
            btnSearchParts.TabIndex = 122;
            btnSearchParts.Text = "Search";
            btnSearchParts.UseVisualStyleBackColor = true;
            btnSearchParts.Click += btnSearchParts_Click;
            // 
            // txtSearchParts
            // 
            txtSearchParts.Location = new Point(1184, 37);
            txtSearchParts.Name = "txtSearchParts";
            txtSearchParts.Size = new Size(331, 31);
            txtSearchParts.TabIndex = 121;
            // 
            // dgvLinkedParts
            // 
            dgvLinkedParts.AllowUserToAddRows = false;
            dgvLinkedParts.AllowUserToDeleteRows = false;
            dgvLinkedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLinkedParts.Location = new Point(615, 496);
            dgvLinkedParts.MultiSelect = false;
            dgvLinkedParts.Name = "dgvLinkedParts";
            dgvLinkedParts.ReadOnly = true;
            dgvLinkedParts.RowHeadersWidth = 62;
            dgvLinkedParts.RowTemplate.Height = 33;
            dgvLinkedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLinkedParts.Size = new Size(900, 309);
            dgvLinkedParts.TabIndex = 120;
            // 
            // dgvAllParts
            // 
            dgvAllParts.AllowUserToAddRows = false;
            dgvAllParts.AllowUserToDeleteRows = false;
            dgvAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllParts.Location = new Point(615, 100);
            dgvAllParts.MultiSelect = false;
            dgvAllParts.Name = "dgvAllParts";
            dgvAllParts.ReadOnly = true;
            dgvAllParts.RowHeadersWidth = 62;
            dgvAllParts.RowTemplate.Height = 33;
            dgvAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllParts.Size = new Size(900, 286);
            dgvAllParts.TabIndex = 119;
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
            pnlFooter.TabIndex = 118;
            // 
            // frmModifyProduct
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
            Controls.Add(txtProductId);
            Controls.Add(txtName);
            Controls.Add(txtInventory);
            Controls.Add(txtPriceCost);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Controls.Add(lblProductId);
            Controls.Add(lblPriceCost);
            Controls.Add(lblName);
            Controls.Add(lblInventory);
            Controls.Add(btnDelete);
            Controls.Add(btnAddPart);
            Controls.Add(lblModifyProduct);
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
            Name = "frmModifyProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            pnlValidationErrors.ResumeLayout(false);
            pnlValidationErrors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLinkedParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValidationErrors;
        private Panel pnlValidationErrors;
        private Label lblMinValidation;
        private Label lblMaxValidation;
        private Label lblPriceCostValidation;
        private Label lblInventoryValidation;
        private Button btnCancel;
        private Label lblNameValidation;
        private TextBox txtProductId;
        private Button btnSave;
        private TextBox txtName;
        private TextBox txtInventory;
        private TextBox txtPriceCost;
        private TextBox txtMin;
        private TextBox txtMax;
        private Label lblMin;
        private Label lblMax;
        private Label lblProductId;
        private Label lblPriceCost;
        private Label lblName;
        private Label lblInventory;
        private Button btnDelete;
        private Button btnAddPart;
        private Label lblModifyProduct;
        private Label lblLinkedParts;
        private Label lblAllParts;
        private Button btnSearchParts;
        private TextBox txtSearchParts;
        private DataGridView dgvLinkedParts;
        private DataGridView dgvAllParts;
        private Panel pnlFooter;
    }
}