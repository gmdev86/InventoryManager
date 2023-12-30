using FluentValidation;

namespace InventoryManager.Core.Validators
{
    public class PartValidator : AbstractValidator<Part>
    {
        public PartValidator()
        {
            RuleFor(part => part.Min)
                .Must((part, min) => min < part.Max)
                .WithMessage("Min must be less than Max.")
                .NotEmpty().WithMessage("Min: Required field.")
                .NotNull();

            RuleFor(part => part.Max)
                .Must((part, max) => max > part.Min)
                .WithMessage("Max must be greater than Min.")
                .NotEmpty().WithMessage("Max: Required field.")
                .NotNull();

            RuleFor(part => part.Name)
                .NotEmpty().WithMessage("Part Name: Required field.")
                .NotNull()
                .MaximumLength(255).WithMessage("Part Name: Maximum allowed: 255.");

            RuleFor(part => part.Inv)
                .NotEmpty().WithMessage("Inventory: Required field.")
                .NotNull();

            RuleFor(part => part.Price)
                .NotEmpty().WithMessage("Price/Cost: Required field.")
                .NotNull();

            RuleFor(part => part)
                .Must(HaveValueInCompanyNameIfOutsourcedPart)
                .WithMessage("Company Name: Must have a value.");

            RuleFor(part => part)
                .Must(MachineIdMustBeGreaterThanZeroIfInHousePart)
                .WithMessage("Machine Id: Must be greater than zero.");

            RuleFor(part => part)
                .Must(BeWithinRange)
                .WithMessage("Inventory: Must be between min and max.");
        }

        private bool HaveValueInCompanyNameIfOutsourcedPart(Part part)
        {
            if (part is InHousePart)
            {
                return true;
            }

            return !string.IsNullOrEmpty(((OutsourcedPart)part).CompanyName);
        }

        private bool MachineIdMustBeGreaterThanZeroIfInHousePart(Part part)
        {
            if (part is OutsourcedPart)
            {
                return true;
            }

            return ((InHousePart)part).PartId > 0;
        }

        private bool BeWithinRange(Part part)
        {
            return part.Inv >= part.Min && part.Inv <= part.Max;
        }
    }
}
