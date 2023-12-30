using FluentValidation.Results;
using InventoryManager.Core;
using InventoryManager.Core.Interfaces;
using System.Text;
using InventoryManager.Core.Validators;

namespace InventoryManager
{
    public partial class frmModifyPart : Form
    {
        private readonly IDataAccessService _dataAccessService;
        private int _id;
        public frmModifyPart(Part part, IDataAccessService dataAccessService)
        {
            InitializeComponent();
            PopulateFields(part);
            _dataAccessService = dataAccessService;
            SetupControls();
        }

        private void SetupControls()
        {
            lblValidationErrors.Text = string.Empty;
            lblValidationErrors.Visible = false;
            pnlValidationErrors.Visible = false;
        }

        private void PopulateFields(Part part)
        {
            _id = (int)part.Id;

            if (part is InHousePart)
            {
                rdoInHouse.Checked = true;
                txtMachineId.Text = ((InHousePart)part).PartId.ToString();
                txtMachineId.Visible = true;
                lblMachineId.Visible = true;
                txtCompanyName.Visible = false;
                lblCompanyName.Visible = false;
            }
            else
            {
                rdoOutsourced.Checked = true;
                txtCompanyName.Text = ((OutsourcedPart)part).CompanyName;
                txtCompanyName.Visible = true;
                lblCompanyName.Visible = true;
                txtMachineId.Visible = false;
                lblMachineId.Visible = false;
            }

            txtPartId.Text = part.Id.ToString();
            txtName.Text = part.Name;
            txtInventory.Text = part.Inv.ToString();
            txtPriceCost.Text = part.Price.ToString();
            txtMax.Text = part.Max.ToString();
            txtMin.Text = part.Min.ToString();
            lblCompanyNameValidation.Visible = false;
            lblMachineIdValidation.Visible = false;
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

            if (rdoInHouse.Checked)
            {
                var machineIdValidation = numericTextBoxValidator.Validate(txtMachineId);
                validationFailures.AddRange(machineIdValidation.Errors);
                SetTextBoxStyle(txtMachineId, lblMachineIdValidation, machineIdValidation);
            }
            else
            {
                var companyNameValidation = requiredTextBoxValidator.Validate(txtCompanyName);
                validationFailures.AddRange(companyNameValidation.Errors);
                SetTextBoxStyle(txtCompanyName, lblCompanyNameValidation, companyNameValidation);
            }

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

        private void rdoInHouse_Click(object sender, EventArgs e)
        {
            if (rdoInHouse.Focused)
            {
                lblMachineId.Visible = true;
                txtMachineId.Visible = true;
                lblCompanyName.Visible = false;
                txtCompanyName.Visible = false;
                txtCompanyName.Text = String.Empty;
                lblCompanyNameValidation.Text = String.Empty;
                lblCompanyNameValidation.Visible = true;
                SetTextBoxStyle(txtCompanyName, lblCompanyNameValidation, null);
                SetTextBoxStyle(txtMachineId, lblMachineIdValidation, null);
            }
        }

        private void rdoOutsourced_Click(object sender, EventArgs e)
        {
            if (rdoOutsourced.Focused)
            {
                lblMachineId.Visible = false;
                txtMachineId.Visible = false;
                txtMachineId.Text = String.Empty;
                lblMachineIdValidation.Text = String.Empty;
                lblMachineIdValidation.Visible = false;
                lblCompanyName.Visible = true;
                txtCompanyName.Visible = true;
                SetTextBoxStyle(txtCompanyName, lblCompanyNameValidation, null);
                SetTextBoxStyle(txtMachineId, lblMachineIdValidation, null);
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSavePart.Focused)
            {
                var validator = new RequiredTextBoxValidator();
                var validationResult = validator.Validate(txtName);
                SetTextBoxStyle(txtName, lblNameValidation, validationResult);
            }
        }

        private void txtInventory_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSavePart.Focused)
            {
                var validator = new NumericTextBoxValidator();
                var validationResult = validator.Validate(txtInventory);
                SetTextBoxStyle(txtInventory, lblInventoryValidation, validationResult);
            }
        }

        private void txtPriceCost_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSavePart.Focused)
            {
                var validator = new DecimalTextBoxValidator();
                var validationResult = validator.Validate(txtPriceCost);
                SetTextBoxStyle(txtPriceCost, lblPriceCostValidation, validationResult);
            }
        }

        private void txtMax_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSavePart.Focused)
            {
                var validator = new NumericTextBoxValidator();
                var validationResult = validator.Validate(txtMax);
                SetTextBoxStyle(txtMax, lblMaxValidation, validationResult);
            }
        }

        private void txtMin_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSavePart.Focused)
            {
                var validator = new NumericTextBoxValidator();
                var validationResult = validator.Validate(txtMin);
                SetTextBoxStyle(txtMin, lblMinValidation, validationResult);
            }
        }

        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSavePart.Focused)
            {
                var validator = new RequiredTextBoxValidator();
                var validationResult = validator.Validate(txtCompanyName);
                SetTextBoxStyle(txtCompanyName, lblCompanyNameValidation, validationResult);
            }
        }

        private void txtMachineId_Leave(object sender, EventArgs e)
        {
            if (!btnCancel.Focused || !btnSavePart.Focused)
            {
                var validator = new NumericTextBoxValidator();
                var validationResult = validator.Validate(txtMachineId);
                SetTextBoxStyle(txtMachineId, lblMachineIdValidation, validationResult);
            }
        }

        private void btnSavePart_Click(object sender, EventArgs e)
        {
            try
            {
                List<ValidationFailure> validationFailures = ValidateAll();

                if (validationFailures.Count == 0)
                {
                    var validator = new PartValidator();
                    Part modifiedPart;
                    if (rdoInHouse.Checked)
                    {
                        modifiedPart = new InHousePart(
                            txtName.Text,
                            double.Parse(txtPriceCost.Text),
                            int.Parse(txtInventory.Text),
                            int.Parse(txtMin.Text),
                            int.Parse(txtMax.Text),
                            int.Parse(txtMachineId.Text));
                    }
                    else
                    {
                        modifiedPart = new OutsourcedPart(
                            txtName.Text,
                            double.Parse(txtPriceCost.Text),
                            int.Parse(txtInventory.Text),
                            int.Parse(txtMin.Text),
                            int.Parse(txtMax.Text),
                            txtCompanyName.Text);
                    }

                    var validationResult = validator.Validate(modifiedPart);

                    if (validationResult.IsValid)
                    {
                        modifiedPart.Id = _id;
                        _dataAccessService.UpdatePart(modifiedPart);
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
                MessageBox.Show(ex.Message, "Failed to update Part", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
