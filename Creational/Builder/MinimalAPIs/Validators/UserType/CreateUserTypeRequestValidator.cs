
namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Validators.UserType;

public sealed class CreateUserTypeRequestValidator : AbstractValidator<CreateUserTypeRequest>
{
    public CreateUserTypeRequestValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Name can't be empty or null.");
    }
}