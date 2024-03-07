var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.ConfigureServiceDbContext(builder.Configuration)
                    .ConfigureLocatorServices(builder.Configuration)
                    .ConfigureMapper()
                    .ConfigureAppSettings(builder.Configuration);
}

var app = builder.Build();
{
    app.MapGet("/locations/{ip:required}",
        async ([FromKeyedServices(LocationProxy.LocatorName)] IGeoLocator geoLocator, IMapper mapper, string ip, CancellationToken cancellationToken) => 
        {
            var location = await geoLocator.GetAsync(ip, cancellationToken);
            return mapper.Map<LocationResponse>(location);
        });
}
app.Run();