using System.Text;
using FluentValidation.Results;
using InventoryManager.Core;
using InventoryManager.Core.Interfaces;
using InventoryManager.Core.Validators;

namespace InventoryManager
{
    public partial class frmAddPart : Form
    {
        private readonly IDataAccessService _dataAccessService;

        public frmAddPart(IDataAccessService dataAccessService)
        {
            InitializeComponent();
            _dataAccessService = dataAccessService;
            SetupControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoOutsourced_Click(object sender, EventArgs e)
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

        private void rdoInHouse_Click(object sender, EventArgs e)
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

        private void btnSavePart_Click(object sender, EventArgs e)
        {
            try
            {
                List<ValidationFailure> validationFailures = ValidateAll();

                if (validationFailures.Count == 0)
                {
                    var validator = new PartValidator();
                    Part newPart;
                    if (rdoInHouse.Checked)
                    {
                        newPart = new InHousePart(
                            txtName.Text,
                            double.Parse(txtPriceCost.Text),
                            int.Parse(txtInventory.Text),
                            int.Parse(txtMin.Text),
                            int.Parse(txtMax.Text),
                            int.Parse(txtMachineId.Text));
                    }
                    else
                    {
                        newPart = new OutsourcedPart(
                            txtName.Text,
                            double.Parse(txtPriceCost.Text),
                            int.Parse(txtInventory.Text),
                            int.Parse(txtMin.Text),
                            int.Parse(txtMax.Text),
                            txtCompanyName.Text);
                    }

                    var validationResult = validator.Validate(newPart);

                    if (validationResult.IsValid)
                    {
                        _dataAccessService.AddPart(newPart);
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
                MessageBox.Show(ex.Message, "Failed to save Part", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void SetupControls()
        {
            rdoInHouse.Checked = true;
            lblMachineId.Visible = true;
            txtMachineId.Visible = true;
            lblCompanyName.Visible = false;
            txtCompanyName.Visible = false;
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
            lblCompanyNameValidation.Text = string.Empty;
            lblCompanyNameValidation.Visible = false;
            lblMachineIdValidation.Text = string.Empty;
            lblMachineIdValidation.Visible = false;
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
    }
}
