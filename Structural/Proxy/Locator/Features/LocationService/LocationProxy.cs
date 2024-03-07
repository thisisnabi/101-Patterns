namespace Thisisnabi.DesignPattern.Structural.Locator.Features.LocationService;

public class LocationProxy([FromKeyedServices(GeoLocatorApi.LocatorName)] IGeoLocator geoLocator, LocatorDbContext dbContext) : IGeoLocator
{
    public const string LocatorName = "LocationProxy";

    public async Task<Location> GetAsync(string ip, CancellationToken cancellationToken)
    {
        var localLocation = await dbContext.Locations.FindAsync(ip, cancellationToken);

        if (localLocation is not null)
            return localLocation;

        var ipgLocation = await geoLocator.GetAsync(ip, cancellationToken);
        ipgLocation.IP = ip;

        await dbContext.AddAsync(ipgLocation, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);

        return ipgLocation;
    }
}