
namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Validators.UserType;

public sealed class UpdateUserTypeRequstValidator : AbstractValidator<UpdateUserTypeRequst>
{
    public UpdateUserTypeRequstValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Name can't be empty or null.");
    }
}