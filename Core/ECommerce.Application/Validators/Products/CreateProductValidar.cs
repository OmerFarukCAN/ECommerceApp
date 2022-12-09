using ECommerce.Application.ViewModels.Products;
using FluentValidation;

namespace ECommerce.Application.Validators.Products
{
    public class CreateProductValidar : AbstractValidator<VmCreateProduct>
    {
        public CreateProductValidar()
        {
            RuleFor(p => p.ProductName)
                .NotEmpty()
                .WithMessage("The product name cannot be empty. Please enter a valid value.")
                .NotNull()
                .WithMessage("The product name cannot be empty. Please enter a valid value.")
                .MaximumLength(150)
                .MinimumLength(3)
                .WithMessage("Please enter the product name between 5 and 150 characters.");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .WithMessage("The stock cannot be empty. Please enter a valid value.")
                .NotNull()
                .WithMessage("The stock cannot be empty. Please enter a valid value.")
                .Must(s => s >= 0)
                .WithMessage("Stock information cannot be less than 0. Please enter a valid value.");

            RuleFor(p => p.Price)
                .NotEmpty()
                .WithMessage("The price cannot be empty. Please enter a valid value.")
                .NotNull()
                .WithMessage("The price cannot be empty. Please enter a valid value.")
                .Must(p => p >= 0)
                .WithMessage("Price information cannot be less than 0. Please enter a valid value.");
        }             
    }
}
