namespace InventoryManager
{
    partial class frmModifyPart
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
            lblMachineIdValidation = new Label();
            lblMinValidation = new Label();
            lblMaxValidation = new Label();
            lblPriceCostValidation = new Label();
            lblInventoryValidation = new Label();
            lblCompanyNameValidation = new Label();
            pnlForm = new Panel();
            lblModifyPart = new Label();
            lblNameValidation = new Label();
            txtPartId = new TextBox();
            txtName = new TextBox();
            panel1 = new Panel();
            rdoInHouse = new RadioButton();
            rdoOutsourced = new RadioButton();
            txtInventory = new TextBox();
            txtCompanyName = new TextBox();
            txtPriceCost = new TextBox();
            lblCompanyName = new Label();
            txtMin = new TextBox();
            lblMachineId = new Label();
            txtMax = new TextBox();
            lblMin = new Label();
            txtMachineId = new TextBox();
            lblMax = new Label();
            lblPartId = new Label();
            lblPriceCost = new Label();
            lblName = new Label();
            lblInventory = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlFooter = new Panel();
            btnSavePart = new Button();
            btnCancel = new Button();
            pnlValidationErrors = new Panel();
            pnlForm.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlValidationErrors.SuspendLayout();
            SuspendLayout();
            // 
            // lblValidationErrors
            // 
            lblValidationErrors.AutoSize = true;
            lblValidationErrors.ForeColor = Color.Red;
            lblValidationErrors.Location = new Point(9, 5);
            lblValidationErrors.Name = "lblValidationErrors";
            lblValidationErrors.Size = new Size(136, 25);
            lblValidationErrors.TabIndex = 0;
            lblValidationErrors.Text = "ValidationErrors";
            lblValidationErrors.Visible = false;
            // 
            // lblMachineIdValidation
            // 
            lblMachineIdValidation.AutoSize = true;
            lblMachineIdValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMachineIdValidation.ForeColor = Color.Red;
            lblMachineIdValidation.Location = new Point(183, 554);
            lblMachineIdValidation.Margin = new Padding(3, 0, 3, 15);
            lblMachineIdValidation.Name = "lblMachineIdValidation";
            lblMachineIdValidation.Size = new Size(89, 25);
            lblMachineIdValidation.TabIndex = 29;
            lblMachineIdValidation.Text = "Required";
            lblMachineIdValidation.Visible = false;
            // 
            // lblMinValidation
            // 
            lblMinValidation.AutoSize = true;
            lblMinValidation.BackColor = SystemColors.Control;
            lblMinValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMinValidation.ForeColor = Color.Red;
            lblMinValidation.Location = new Point(438, 467);
            lblMinValidation.Name = "lblMinValidation";
            lblMinValidation.Size = new Size(89, 25);
            lblMinValidation.TabIndex = 28;
            lblMinValidation.Text = "Required";
            lblMinValidation.Visible = false;
            // 
            // lblMaxValidation
            // 
            lblMaxValidation.AutoSize = true;
            lblMaxValidation.BackColor = SystemColors.Control;
            lblMaxValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaxValidation.ForeColor = Color.Red;
            lblMaxValidation.Location = new Point(183, 467);
            lblMaxValidation.Name = "lblMaxValidation";
            lblMaxValidation.Size = new Size(89, 25);
            lblMaxValidation.TabIndex = 27;
            lblMaxValidation.Text = "Required";
            lblMaxValidation.Visible = false;
            // 
            // lblPriceCostValidation
            // 
            lblPriceCostValidation.AutoSize = true;
            lblPriceCostValidation.BackColor = SystemColors.Control;
            lblPriceCostValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriceCostValidation.ForeColor = Color.Red;
            lblPriceCostValidation.Location = new Point(183, 382);
            lblPriceCostValidation.Name = "lblPriceCostValidation";
            lblPriceCostValidation.Size = new Size(89, 25);
            lblPriceCostValidation.TabIndex = 26;
            lblPriceCostValidation.Text = "Required";
            lblPriceCostValidation.Visible = false;
            // 
            // lblInventoryValidation
            // 
            lblInventoryValidation.AutoSize = true;
            lblInventoryValidation.BackColor = SystemColors.Control;
            lblInventoryValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInventoryValidation.ForeColor = Color.Red;
            lblInventoryValidation.Location = new Point(183, 307);
            lblInventoryValidation.Name = "lblInventoryValidation";
            lblInventoryValidation.Size = new Size(89, 25);
            lblInventoryValidation.TabIndex = 25;
            lblInventoryValidation.Text = "Required";
            lblInventoryValidation.Visible = false;
            // 
            // lblCompanyNameValidation
            // 
            lblCompanyNameValidation.AutoSize = true;
            lblCompanyNameValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanyNameValidation.ForeColor = Color.Red;
            lblCompanyNameValidation.Location = new Point(183, 551);
            lblCompanyNameValidation.Margin = new Padding(3, 0, 3, 15);
            lblCompanyNameValidation.Name = "lblCompanyNameValidation";
            lblCompanyNameValidation.Size = new Size(89, 25);
            lblCompanyNameValidation.TabIndex = 24;
            lblCompanyNameValidation.Text = "Required";
            // 
            // pnlForm
            // 
            pnlForm.AutoSize = true;
            pnlForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlForm.Controls.Add(lblMachineIdValidation);
            pnlForm.Controls.Add(lblMinValidation);
            pnlForm.Controls.Add(lblMaxValidation);
            pnlForm.Controls.Add(lblPriceCostValidation);
            pnlForm.Controls.Add(lblInventoryValidation);
            pnlForm.Controls.Add(lblCompanyNameValidation);
            pnlForm.Controls.Add(lblModifyPart);
            pnlForm.Controls.Add(lblNameValidation);
            pnlForm.Controls.Add(txtPartId);
            pnlForm.Controls.Add(txtName);
            pnlForm.Controls.Add(panel1);
            pnlForm.Controls.Add(txtInventory);
            pnlForm.Controls.Add(txtCompanyName);
            pnlForm.Controls.Add(txtPriceCost);
            pnlForm.Controls.Add(lblCompanyName);
            pnlForm.Controls.Add(txtMin);
            pnlForm.Controls.Add(lblMachineId);
            pnlForm.Controls.Add(txtMax);
            pnlForm.Controls.Add(lblMin);
            pnlForm.Controls.Add(txtMachineId);
            pnlForm.Controls.Add(lblMax);
            pnlForm.Controls.Add(lblPartId);
            pnlForm.Controls.Add(lblPriceCost);
            pnlForm.Controls.Add(lblName);
            pnlForm.Controls.Add(lblInventory);
            pnlForm.Dock = DockStyle.Top;
            pnlForm.Location = new Point(3, 39);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(655, 594);
            pnlForm.TabIndex = 0;
            // 
            // lblModifyPart
            // 
            lblModifyPart.AutoSize = true;
            lblModifyPart.Location = new Point(16, 33);
            lblModifyPart.Margin = new Padding(4, 0, 4, 0);
            lblModifyPart.Name = "lblModifyPart";
            lblModifyPart.Size = new Size(104, 25);
            lblModifyPart.TabIndex = 0;
            lblModifyPart.Text = "Modify Part";
            // 
            // lblNameValidation
            // 
            lblNameValidation.AutoSize = true;
            lblNameValidation.BackColor = SystemColors.Control;
            lblNameValidation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameValidation.ForeColor = Color.Red;
            lblNameValidation.Location = new Point(183, 224);
            lblNameValidation.Name = "lblNameValidation";
            lblNameValidation.Size = new Size(89, 25);
            lblNameValidation.TabIndex = 23;
            lblNameValidation.Text = "Required";
            lblNameValidation.Visible = false;
            // 
            // txtPartId
            // 
            txtPartId.Enabled = false;
            txtPartId.Location = new Point(183, 113);
            txtPartId.Margin = new Padding(4, 5, 4, 5);
            txtPartId.Name = "txtPartId";
            txtPartId.Size = new Size(141, 31);
            txtPartId.TabIndex = 99;
            txtPartId.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(183, 188);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 31);
            txtName.TabIndex = 3;
            txtName.Leave += txtName_Leave;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(rdoInHouse);
            panel1.Controls.Add(rdoOutsourced);
            panel1.Location = new Point(132, 33);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 48);
            panel1.TabIndex = 0;
            // 
            // rdoInHouse
            // 
            rdoInHouse.AutoSize = true;
            rdoInHouse.Location = new Point(4, 5);
            rdoInHouse.Margin = new Padding(4, 5, 4, 5);
            rdoInHouse.Name = "rdoInHouse";
            rdoInHouse.Size = new Size(110, 29);
            rdoInHouse.TabIndex = 99;
            rdoInHouse.Text = "In-House";
            rdoInHouse.UseVisualStyleBackColor = true;
            rdoInHouse.Click += rdoInHouse_Click;
            // 
            // rdoOutsourced
            // 
            rdoOutsourced.AutoSize = true;
            rdoOutsourced.Location = new Point(143, 5);
            rdoOutsourced.Margin = new Padding(4, 5, 4, 5);
            rdoOutsourced.Name = "rdoOutsourced";
            rdoOutsourced.Size = new Size(130, 29);
            rdoOutsourced.TabIndex = 99;
            rdoOutsourced.Text = "Outsourced";
            rdoOutsourced.UseVisualStyleBackColor = true;
            rdoOutsourced.Click += rdoOutsourced_Click;
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(183, 271);
            txtInventory.Margin = new Padding(4, 5, 4, 5);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(141, 31);
            txtInventory.TabIndex = 5;
            txtInventory.Leave += txtInventory_Leave;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(183, 515);
            txtCompanyName.Margin = new Padding(4, 5, 4, 5);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(141, 31);
            txtCompanyName.TabIndex = 13;
            txtCompanyName.Visible = false;
            txtCompanyName.Leave += txtCompanyName_Leave;
            // 
            // txtPriceCost
            // 
            txtPriceCost.Location = new Point(183, 346);
            txtPriceCost.Margin = new Padding(4, 5, 4, 5);
            txtPriceCost.Name = "txtPriceCost";
            txtPriceCost.Size = new Size(141, 31);
            txtPriceCost.TabIndex = 7;
            txtPriceCost.Leave += txtPriceCost_Leave;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(32, 520);
            lblCompanyName.Margin = new Padding(4, 0, 4, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(149, 25);
            lblCompanyName.TabIndex = 12;
            lblCompanyName.Text = "Company Name*";
            lblCompanyName.Visible = false;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(438, 431);
            txtMin.Margin = new Padding(4, 5, 4, 5);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(141, 31);
            txtMin.TabIndex = 10;
            txtMin.Leave += txtMin_Leave;
            // 
            // lblMachineId
            // 
            lblMachineId.AutoSize = true;
            lblMachineId.Location = new Point(74, 520);
            lblMachineId.Margin = new Padding(4, 0, 4, 0);
            lblMachineId.Name = "lblMachineId";
            lblMachineId.Size = new Size(107, 25);
            lblMachineId.TabIndex = 16;
            lblMachineId.Text = "Machine Id*";
            // 
            // txtMax
            // 
            txtMax.Location = new Point(183, 431);
            txtMax.Margin = new Padding(4, 5, 4, 5);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(141, 31);
            txtMax.TabIndex = 9;
            txtMax.Leave += txtMax_Leave;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(389, 436);
            lblMin.Margin = new Padding(4, 0, 4, 0);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(50, 25);
            lblMin.TabIndex = 10;
            lblMin.Text = "Min*";
            // 
            // txtMachineId
            // 
            txtMachineId.Location = new Point(183, 515);
            txtMachineId.Margin = new Padding(4, 5, 4, 5);
            txtMachineId.Name = "txtMachineId";
            txtMachineId.Size = new Size(141, 31);
            txtMachineId.TabIndex = 11;
            txtMachineId.Leave += txtMachineId_Leave;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(127, 436);
            lblMax.Margin = new Padding(4, 0, 4, 0);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(53, 25);
            lblMax.TabIndex = 8;
            lblMax.Text = "Max*";
            // 
            // lblPartId
            // 
            lblPartId.AutoSize = true;
            lblPartId.Location = new Point(151, 118);
            lblPartId.Margin = new Padding(4, 0, 4, 0);
            lblPartId.Name = "lblPartId";
            lblPartId.Size = new Size(28, 25);
            lblPartId.TabIndex = 99;
            lblPartId.Text = "Id";
            // 
            // lblPriceCost
            // 
            lblPriceCost.AutoSize = true;
            lblPriceCost.Location = new Point(71, 351);
            lblPriceCost.Margin = new Padding(4, 0, 4, 0);
            lblPriceCost.Name = "lblPriceCost";
            lblPriceCost.Size = new Size(110, 25);
            lblPriceCost.TabIndex = 6;
            lblPriceCost.Text = "Price / Cost*";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(111, 193);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Name*";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(86, 276);
            lblInventory.Margin = new Padding(4, 0, 4, 0);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(95, 25);
            lblInventory.TabIndex = 4;
            lblInventory.Text = "Inventory*";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 661F));
            tableLayoutPanel1.Controls.Add(pnlForm, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlFooter, 0, 2);
            tableLayoutPanel1.Controls.Add(pnlValidationErrors, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(626, 699);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // pnlFooter
            // 
            pnlFooter.AutoSize = true;
            pnlFooter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFooter.BackColor = SystemColors.ActiveCaption;
            pnlFooter.Controls.Add(btnSavePart);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Dock = DockStyle.Fill;
            pnlFooter.Location = new Point(0, 636);
            pnlFooter.Margin = new Padding(0);
            pnlFooter.MaximumSize = new Size(0, 68);
            pnlFooter.MinimumSize = new Size(0, 68);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(661, 68);
            pnlFooter.TabIndex = 22;
            // 
            // btnSavePart
            // 
            btnSavePart.Location = new Point(377, 13);
            btnSavePart.Margin = new Padding(4, 5, 4, 5);
            btnSavePart.Name = "btnSavePart";
            btnSavePart.Size = new Size(107, 38);
            btnSavePart.TabIndex = 17;
            btnSavePart.Text = "Save";
            btnSavePart.UseVisualStyleBackColor = true;
            btnSavePart.Click += btnSavePart_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(499, 13);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnlValidationErrors
            // 
            pnlValidationErrors.AutoSize = true;
            pnlValidationErrors.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlValidationErrors.Controls.Add(lblValidationErrors);
            pnlValidationErrors.Dock = DockStyle.Fill;
            pnlValidationErrors.Location = new Point(3, 3);
            pnlValidationErrors.Name = "pnlValidationErrors";
            pnlValidationErrors.Size = new Size(655, 30);
            pnlValidationErrors.TabIndex = 1;
            // 
            // frmModifyPart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(626, 699);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmModifyPart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Part";
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlValidationErrors.ResumeLayout(false);
            pnlValidationErrors.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValidationErrors;
        private Label lblMachineIdValidation;
        private Label lblMinValidation;
        private Label lblMaxValidation;
        private Label lblPriceCostValidation;
        private Label lblInventoryValidation;
        private Label lblCompanyNameValidation;
        private Panel pnlForm;
        private Label lblModifyPart;
        private Label lblNameValidation;
        private TextBox txtPartId;
        private TextBox txtName;
        private Panel panel1;
        private RadioButton rdoInHouse;
        private RadioButton rdoOutsourced;
        private TextBox txtInventory;
        private TextBox txtCompanyName;
        private TextBox txtPriceCost;
        private Label lblCompanyName;
        private TextBox txtMin;
        private Label lblMachineId;
        private TextBox txtMax;
        private Label lblMin;
        private TextBox txtMachineId;
        private Label lblMax;
        private Label lblPartId;
        private Label lblPriceCost;
        private Label lblName;
        private Label lblInventory;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlFooter;
        private Button btnSavePart;
        private Button btnCancel;
        private Panel pnlValidationErrors;
    }
}