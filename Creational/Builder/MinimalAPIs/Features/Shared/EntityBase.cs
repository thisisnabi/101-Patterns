namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Features.Shared;

public abstract class EntityBase
{
    public Guid Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }
}