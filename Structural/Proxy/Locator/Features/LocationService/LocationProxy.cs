namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Features.LocationService;

/// <summary>
/// Proxy class that implements IGeoLocator and acts as an intermediary between the client and the real location service.
/// (This is the proxy in the Proxy Pattern)
/// </summary>
public class LocationProxy([FromKeyedServices(GeoLocatorApi.LocatorName)] IGeoLocator geoLocator, LocatorDbContext dbContext) : IGeoLocator
{
    public const string LocatorName = "LocationProxy";

    public async Task<Location> GetAsync(string ip, CancellationToken cancellationToken)
    {
        // Check the local database first for the requested IP address
        var localLocation = await dbContext.Locations.FindAsync(ip, cancellationToken);

        if (localLocation is not null)
        {
            // Return the cached location data if found
            return localLocation;
        }

        // If not found in the cache, fetch data from the real location service (GeoLocatorApi)
        var ipgLocation = await geoLocator.GetAsync(ip, cancellationToken);
        ipgLocation.IP = ip; // Ensure IP is set correctly

        // Cache the retrieved location data in the database
        await dbContext.AddAsync(ipgLocation, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);

        return ipgLocation;
    }
}