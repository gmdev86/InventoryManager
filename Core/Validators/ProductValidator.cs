using FluentValidation;

namespace InventoryManager.Core.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Min)
                .Must((product, min) => min < product.Max)
                .WithMessage("Min must be less than Max.")
                .NotEmpty().WithMessage("Min: Required field.")
                .NotNull();

            RuleFor(product => product.Max)
                .Must((product, max) => max > product.Min)
                .WithMessage("Max must be greater than Min.")
                .NotEmpty().WithMessage("Max: Required field.")
                .NotNull();

            RuleFor(product => product.Name)
                .NotEmpty().WithMessage("Product Name: Required field.")
                .NotNull()
                .MaximumLength(255).WithMessage("Product Name: Maximum allowed: 255.");

            RuleFor(product => product.Inv)
                .NotEmpty().WithMessage("Inventory: Required field.")
                .NotNull();

            RuleFor(product => product.Price)
                .NotEmpty().WithMessage("Price/Cost: Required field.")
                .NotNull();

            RuleFor(product => product)
                .Must(BeWithinRange)
                .WithMessage("Inventory: Must be between min and max.");
        }

        private bool BeWithinRange(Product product)
        {
            return product.Inv >= product.Min && product.Inv <= product.Max;
        }
    }
}
