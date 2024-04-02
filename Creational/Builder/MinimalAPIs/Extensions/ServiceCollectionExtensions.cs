namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection SetupPersistence(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source = MinimalAPIsDb.db"));

        return services;
    }

    public static IServiceCollection SetupSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    public static IServiceCollection SetupMapster(this IServiceCollection services)
    {
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();

        return services;
    }

    public static IServiceCollection SetupFluentValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<AppDbContext>();
        return services;
    }
}