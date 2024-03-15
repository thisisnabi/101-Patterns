namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Extensions;

public static class ServiceCollectionExtensions
{
    // Extension method for registering the database context in the DI container
    public static IServiceCollection ConfigureServiceDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        // Add the LocatorDbContext to the DI container, using a configuration-based connection string
        services.AddDbContext<LocatorDbContext>(options =>
        {
            var conStr = configuration.GetConnectionString(LocatorDbContext.ConnectionStringSectionName); // Retrieve connection string from configuration
            options.UseSqlServer(conStr); // Configure the DbContext to use SQL Server with the provided connection string
        });

        return services; // Return the modified service collection for chaining
    }

    // Extension method for configuring proxy-related services in the DI container
    public static IServiceCollection ConfigureLocatorServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Register both the proxy (LocationProxy) and the real subject (GeoLocatorApi) with the DI container as keyed services
        services.AddKeyedScoped<IGeoLocator, LocationProxy>(LocationProxy.LocatorName); // Register LocationProxy with its unique key
        services.AddKeyedScoped<IGeoLocator, GeoLocatorApi>(GeoLocatorApi.LocatorName); // Register GeoLocatorApi with its unique key

        return services; // Return the modified service collection for chaining
    }

    // Extension method for configuring the mapping service
    public static IServiceCollection ConfigureMapper(this IServiceCollection services)
    {
        // Configure AutoMapper settings
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly()); // Scan the current assembly for mapping profiles

        // Register AutoMapper services in the DI container
        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();

        return services; // Return the modified service collection for chaining
    }

    // Extension method for configuring application settings from a configuration source
    public static IServiceCollection ConfigureAppSettings(this IServiceCollection services, IConfiguration configuration)
    {
        // Bind configuration settings for LocationServiceAppSettings to the DI container
        services.Configure<LocationServiceAppSettings>(configuration.GetSection(LocationServiceAppSettings.SectionName));

        return services; // Return the modified service collection for chaining
    }
}