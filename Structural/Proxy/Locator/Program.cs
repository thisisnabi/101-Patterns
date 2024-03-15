var builder = WebApplication.CreateBuilder(args);
{
    // Configure services using extension methods for better separation of concerns
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
            // Retrieve location information using the injected GeoLocator service
            var location = await geoLocator.GetAsync(ip, cancellationToken);

            // Map the retrieved location data to the desired response format
            return mapper.Map<LocationResponse>(location);
        });
}
app.Run();