using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Persistence.Configurations.Shared.Generators;
namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Persistence.Configurations;

public sealed class UserTypeConfiguration : IEntityTypeConfiguration<UserType>
{
    public void Configure(EntityTypeBuilder<UserType> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedNever();

        builder.Property(p => p.Name)
            .HasMaxLength(25);

        builder.Property(p => p.CreatedOn)
            .ValueGeneratedOnAdd()
            .HasValueGenerator<DateTimeValueGenerator>()
            .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

        builder.Property(p => p.ModifiedOn)
                .ValueGeneratedOnUpdate()
                .HasValueGenerator<DateTimeValueGenerator>();

        builder.ToTable("UserTypes");
    }
}
