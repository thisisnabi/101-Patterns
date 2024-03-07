var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServiceDbContext(builder.Configuration);
builder.Services.ConfigureLocatorServices(builder.Configuration);
builder.Services.ConfigureMapper();
builder.Services.ConfigureAppSettings(builder.Configuration);

var app = builder.Build();

app.MapGet("/locations/{ip:required}", 
    (LocationFinder locationFinder,string ip, CancellationToken cancellationToken) =>
        locationFinder.GetAsync(ip, cancellationToken));

app.Run();



