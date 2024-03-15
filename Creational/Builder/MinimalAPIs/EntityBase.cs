namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs;

public abstract class EntityBase
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }
}