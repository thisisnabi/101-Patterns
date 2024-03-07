namespace Thisisnabi.DesignPattern.Structural.Locator.Features.LocationService;

public class GeoLocatorDatabase([FromKeyedServices(GeoLocatorApi.LocatorName)] IGeoLocator geoLocator, LocatorDbContext dbContext) : IGeoLocator
{
    public const string LocatorName = "GeoLocatorDatabase";

    public async Task<Location> GetAsync(string ipAddress, CancellationToken cancellationToken = default)
    {
        var localLocation = await dbContext.Locations.FindAsync(ipAddress, cancellationToken);

        if (localLocation is not null)
        {
            return localLocation;
        }

        var ipgLocation = await geoLocator.GetAsync(ipAddress, cancellationToken);
        ipgLocation.IP = ipAddress;

        await dbContext.AddAsync(ipgLocation, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);

        return ipgLocation;
    }
}