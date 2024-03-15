using FluentValidation;

namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Features;

internal class UserType : EntityBase
{
    public string Name { get; set; } = null!;
}

internal record CreateUserTypeRequest(string Name);
internal class CreateUserTypeRequestValidator : AbstractValidator<CreateUserTypeRequest>
{
    public CreateUserTypeRequestValidator()
    {

    }
}

internal record CreateUserTypeResponse(string Name, string Guid);

internal record UserTypeResponse(string Name, string Guid);

internal record UpdateUserTypeRequst(string Name);
internal class UpdateUserTypeRequstValidator : AbstractValidator<UpdateUserTypeRequst>
{

}
