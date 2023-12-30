using FluentValidation;

namespace InventoryManager.Core.Validators
{
    public class NumericTextBoxValidator : AbstractValidator<TextBox>
    {
        public NumericTextBoxValidator()
        {
            RuleFor(textBox => textBox.Text)
                .NotEmpty().WithMessage("Required field.")
                .NotNull()
                .Must(BeNumeric).WithMessage("Must be numeric.")
                .Must(BePositive)
                .WithMessage("Must be positive.");
        }

        private bool BeNumeric(string value)
        {
            return int.TryParse(value, out _);
        }

        private bool BePositive(string value)
        {
            int.TryParse(value, out int result);
            return result >= 0;
        }
    }
}
