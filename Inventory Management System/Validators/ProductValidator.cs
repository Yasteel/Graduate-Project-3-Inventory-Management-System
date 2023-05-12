namespace Inventory_Management_System.Validators
{
    using FluentValidation;
    
    using Inventory_Management_System.Models;

    public class ProductValidator : AbstractValidator<Products>
    {
        public ProductValidator()
        {
            this.RuleSet("Create", () =>
            {
                this.GeneralRules();
            });

            this.RuleSet("Update", () =>
            {
                this.GeneralRules();

                this.RuleFor(_ => _.ProductId)
                    .NotNull()
                    .WithMessage("Cannot Leave Product Id Blank")
                    .GreaterThan(0)
                    .WithMessage("Invalid Product Id");
            });

        }

        private void GeneralRules()
        {
            this.RuleFor(_ => _.ProductName)
                .MinimumLength(1)
                .WithMessage("Cannot Leave Product Name Blank")
                .MaximumLength(50)
                .WithMessage("Cannot Exceed 50 Characters");

            this.RuleFor(_ => _.Description)
                .MinimumLength(1)
                .WithMessage("Cannot Leave Product Name Blank")
                .MaximumLength(100)
                .WithMessage("Cannot Exceed 100 Characters");

            this.RuleFor(_ => _.Price)
                .NotNull()
                .WithMessage("Cannot Leave Price Blank")
                .GreaterThan(0)
                .WithMessage("Price cannot be less than R1.00");

            this.RuleFor(_ => _.Quantity)
                .GreaterThan(0)
                .WithMessage("Quantity cannot be Negative")
                .NotNull()
                .WithMessage("Cannot Leave Price Blank");
        }

    }
}
