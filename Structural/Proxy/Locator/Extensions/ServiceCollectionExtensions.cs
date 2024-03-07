namespace Thisisnabi.DesignPattern.Structural.Locator.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection ConfigureServiceDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<LocatorDbContext>(options =>
        {
            var conStr = configuration.GetConnectionString(LocatorDbContext.ConnectionStringSectionName);
            options.UseSqlServer(conStr);
        });

        return services;
    }

    public static IServiceCollection ConfigureLocatorServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddKeyedScoped<IGeoLocator, LocationProxy>(LocationProxy.LocatorName);
        services.AddKeyedScoped<IGeoLocator, GeoLocatorApi>(GeoLocatorApi.LocatorName);
        services.AddScoped<LocationProxy>();
         
        return services;
    }

    public static IServiceCollection ConfigureMapper(this IServiceCollection services)
    {
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();
        return services;
    }

    public static IServiceCollection ConfigureAppSettings(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<LocationServiceAppSettings>(
             configuration.GetSection(LocationServiceAppSettings.SectionName));

        return services;
    }
}
