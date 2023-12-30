using FluentValidation.Results;
using InventoryManager.Core;
using InventoryManager.Core.Interfaces;
using InventoryManager.Core.Validators;
using System.Data;
using System.Text;

namespace InventoryManager
{
    public partial class frmModifyProduct : Form
    {
        private readonly IDataAccessService _dataAccessService;
        private BindingSource _allPartsBindingSource;
        private BindingSource _linkedPartsBindingSource;
        private DataTable _linkedParts = new DataTable();
        private int _id;

        public frmModifyProduct(Product product, IDataAccessService dataAccessService)
        {
            InitializeComponent();
            _dataAccessService = dataAccessService;
            SetupControls();
            InitializeDataBinding();
            InitializeLinkedParts();
            PopulateFields(product);
            LoadAllData();
        }

        private void PopulateFields(Product product)
        {
            _id = (int)product.Id;
            txtProductId.Text = product.Id.ToString();
            txtName.Text = product.Name;
            txtInventory.Text = product.Inv.ToString();
            txtPriceCost.Text = product.Price.ToString();
            txtMax.Text = product.Max.ToString();
            txtMin.Text = product.Min.ToString();

            foreach (ProductPart productPart in product.Parts)
            {
                Part part = _dataAccessService.GetPart(productPart.PartId);
                DataRow row = _linkedParts.NewRow();

                row["Id"] = (int)part.Id;
                row["PartName"] = part.Name;
                row["Inventory"] = part.Inv;
                row["Price"] = part.Price;
                row["Max"] = part.Max;
                row["Min"] = part.Min;

                _linkedParts.Rows.Add(row);
            }
            LoadLinkedParts();
        }

        private void SetTextBoxStyle(TextBox textBox, Label label, ValidationResult? validationResult)
        {
            if (validationResult != null && !validationResult.IsValid)
            {
                label.Text = validationResult.Errors.First().ErrorMessage;
                label.Show();
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.BackColor = Color.LightPink;
                textBox.ForeColor = Color.Red;
            }
            else
            {
                label.Text = string.Empty;
                label.Hide();
                textBox.BorderStyle = BorderStyle.Fixed3D;
                textBox.BackColor = SystemColors.Window;
                textBox.ForeColor = SystemColors.ControlText;
            }
        }

        private void SetupControls()
        {
            lblValidationErrors.Text = string.Empty;
            lblValidationErrors.Visible = false;
            pnlValidationErrors.Visible = false;
            lblNameValidation.Text = string.Empty;
            lblNameValidation.Visible = false;
            lblInventoryValidation.Text = string.Empty;
            lblInventoryValidation.Visible = false;
            lblPriceCostValidation.Text = string.Empty;
            lblPriceCostValidation.Visible = false;
            lblMaxValidation.Text = string.Empty;
            lblMaxValidation.Visible = false;
            lblMinValidation.Text = string.Empty;
            lblMinValidation.Visible = false;
        }

        private void LoadAllData()
        {
            LoadAllParts();
            LoadLinkedParts();
        }

        private void LoadAllParts()
        {
            DataTable dt = _dataAccessService.GetDataFromTable("Part");
            _allPartsBindingSource.DataSource = dt;
            _allPartsBindingSource.ResetBindings(false);
        }

        private void LoadLinkedParts()
        {
            _linkedPartsBindingSource.DataSource = _linkedParts;
            _linkedPartsBindingSource.ResetBindings(false);
        }

        private void InitializeLinkedParts()
        {
            _linkedParts.Columns.Add("Id", typeof(int));
            _linkedParts.Columns.Add("PartName", typeof(string));
            _linkedParts.Columns.Add("Inventory", typeof(int));
            _linkedParts.Columns.Add("Price", typeof(double));
            _linkedParts.Columns.Add("Max", typeof(int));
            _linkedParts.Columns.Add("Min", typeof(int));
        }

        private void InitializeDataBinding()
        {
            _allPartsBindingSource = new BindingSource();
            _allPartsBindingSource.DataSource = dgvAllParts.DataSource;
            dgvAllParts.DataSource = _allPartsBindingSource;

            _linkedPartsBindingSource = new BindingSource();
            _linkedPartsBindingSource.DataSource = dgvLinkedParts.DataSource;
            dgvLinkedParts.DataSource = _linkedPartsBindingSource;
        }

        private DialogResult ShowDeleteConfirmation()
        {
            string message = "Are you sure you want to delete this item?";
            string caption = "Delete Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, caption, buttons, icon);

            return result;
        }

        private List<ValidationFailure> ValidateAll()
        {
            List<ValidationFailure> validationFailures = new List<ValidationFailure>();
            var requiredTextBoxValidator = new RequiredTextBoxValidator();
            var numericTextBoxValidator = new NumericTextBoxValidator();
            var decimalTextBoxValidator = new DecimalTextBoxValidator();
            var nameValidation = requiredTextBoxValidator.Validate(txtName);
            var inventoryValidation = numericTextBoxValidator.Validate(txtInventory);
            var priceValidation = decimalTextBoxValidator.Validate(txtPriceCost);
            var maxValidation = numericTextBoxValidator.Validate(txtMax);
            var minValidation = numericTextBoxValidator.Validate(txtMin);

            validationFailures.AddRange(nameValidation.Errors);
            SetTextBoxStyle(txtName, lblNameValidation, nameValidation);
            validationFailures.AddRange(inventoryValidation.Errors);
            SetTextBoxStyle(txtInventory, lblInventoryValidation, inventoryValidation);
            validationFailures.AddRange(priceValidation.Errors);
            SetTextBoxStyle(txtPriceCost, lblPriceCostValidation, priceValidation);
            validationFailures.AddRange(maxValidation.Errors);
            SetTextBoxStyle(txtMax, lblMaxValidation, maxValidation);
            validationFailures.AddRange(minValidation.Errors);
            SetTextBoxStyle(txtMin, lblMinValidation, minValidation);

            return validationFailures;
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchParts.Text))
            {
                _allPartsBindingSource.RemoveFilter();
            }
            else
            {
                int.TryParse(txtSearchParts.Text, out int searchValue);
                string filterExpression = $"ID = {searchValue} OR PartName LIKE '%{txtSearchParts.Text}%'";
                _allPartsBindingSource.Filter = filterExpression;
            }

            dgvAllParts.Refresh();
            if (dgvAllParts.RowCount == 0)
            {
                MessageBox.Show("No Parts found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAllParts.SelectedRows[0];
                DataRow row = _linkedParts.NewRow();

                row["Id"] = (int)selectedRow.Cells["ID"].Value;
                row["PartName"] = selectedRow.Cells["PartName"].Value;
                row["Inventory"] = (int)selectedRow.Cells["Inventory"].Value;
                row["Price"] = selectedRow.Cells["Price"].Value;
                row["Max"] = (int)selectedRow.Cells["Max"].Value;
                row["Min"] = (int)selectedRow.Cells["Min"].Value;

                _linkedParts.Rows.Add(row);
                LoadLinkedParts();
            }
            else
            {
                MessageBox.Show("Please select Part.", "Part not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLinkedParts.SelectedRows.Count > 0)
            {
                if (ShowDeleteConfirmation() == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgvLinkedParts.SelectedRows[0];

                    var id = (int)selectedRow.Cells["ID"].Value;
                    var linkedPart = _linkedPartsBindingSource.Find("ID", id);
                    _linkedPartsBindingSource.RemoveAt(linkedPart);
                    LoadLinkedParts();
                }
            }
            else
            {
                MessageBox.Show("Please select Part.", "Part not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<ValidationFailure> validationFailures = ValidateAll();

                if (validationFailures.Count == 0)
                {
                    Product product = new Product
                    {
                        Name = txtName.Text,
                        Price = double.Parse(txtPriceCost.Text),
                        Inv = int.Parse(txtInventory.Text),
                        Min = int.Parse(txtMin.Text),
                        Max = int.Parse(txtMax.Text)
                    };

                    var validator = new ProductValidator();
                    var validationResult = validator.Validate(product);

                    if (validationResult.IsValid)
                    {
                        foreach (DataGridViewRow row in dgvLinkedParts.Rows)
                        {
                            product.Parts.Add(new ProductPart
                            {
                                ProductId = _id,
                                PartId = (int)row.Cells["Id"].Value,
                            });
                        }
                        product.Id = _id;
                        _dataAccessService.UpdateProduct(product);
                        MessageBox.Show("Product successfully added!");
                        this.Close();
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (ValidationFailure validationResultError in validationResult.Errors)
                        {
                            sb.AppendLine(validationResultError.ErrorMessage);
                        }
                        lblValidationErrors.Text = sb.ToString();
                        lblValidationErrors.Visible = true;
                        pnlValidationErrors.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to save Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSave.Focused)
            {
                var validator = new RequiredTextBoxValidator();
                var validationResult = validator.Validate(txtName);
                SetTextBoxStyle(txtName, lblNameValidation, validationResult);
            }
        }

        private void txtInventory_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSave.Focused)
            {
                var validator = new NumericTextBoxValidator();
                var validationResult = validator.Validate(txtInventory);
                SetTextBoxStyle(txtInventory, lblInventoryValidation, validationResult);
            }
        }

        private void txtPriceCost_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSave.Focused)
            {
                var validator = new DecimalTextBoxValidator();
                var validationResult = validator.Validate(txtPriceCost);
                SetTextBoxStyle(txtPriceCost, lblPriceCostValidation, validationResult);
            }
        }

        private void txtMax_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSave.Focused)
            {
                var validator = new NumericTextBoxValidator();
                var validationResult = validator.Validate(txtMax);
                SetTextBoxStyle(txtMax, lblMaxValidation, validationResult);
            }
        }

        private void txtMin_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSave.Focused)
            {
                var validator = new NumericTextBoxValidator();
                var validationResult = validator.Validate(txtMin);
                SetTextBoxStyle(txtMin, lblMinValidation, validationResult);
            }
        }
    }
}
