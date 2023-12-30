using FluentValidation;

namespace InventoryManager.Core.Validators
{
    public class RequiredTextBoxValidator : AbstractValidator<TextBox>
    {
        public RequiredTextBoxValidator()
        {
            RuleFor(textBox => textBox.Text)
                .NotEmpty().WithMessage("Required field.")
                .NotNull()
                .MaximumLength(255).WithMessage("Maximum character limit exceeded. Maximum allowed: 255.");
        }
    }
}
