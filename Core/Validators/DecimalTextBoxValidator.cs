using FluentValidation;

namespace InventoryManager.Core.Validators
{
    public class DecimalTextBoxValidator : AbstractValidator<TextBox>
    {
        public DecimalTextBoxValidator()
        {
            RuleFor(textBox => textBox.Text)
                .NotEmpty().WithMessage("Required field.")
                .NotNull()
                .Must(BeDecimal)
                .WithMessage("Must be decimal value.");

        }

        private bool BeDecimal(string value)
        {
            return decimal.TryParse(value, out _);
        }
    }
}
