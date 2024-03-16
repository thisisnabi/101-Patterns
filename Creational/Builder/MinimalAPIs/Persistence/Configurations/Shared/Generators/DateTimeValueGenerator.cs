using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Persistence.Configurations.Shared.Generators;
internal sealed class DateTimeValueGenerator : ValueGenerator<DateTime>
{
    public override bool GeneratesTemporaryValues => false;

    public override DateTime Next(EntityEntry entry)
    {
        return DateTime.Now;
    }
}
