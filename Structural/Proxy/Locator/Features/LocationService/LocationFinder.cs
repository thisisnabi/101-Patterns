namespace Thisisnabi.DesignPattern.Structural.Locator.Features.LocationService;

public class LocationFinder([FromKeyedServices(GeoLocatorDatabase.LocatorName)] IGeoLocator geoLocator, IMapper mapper)
{
    public async Task<LocationResponse> GetAsync(string ip, CancellationToken cancellationToken)
    {
        var location = await geoLocator.GetAsync(ip, cancellationToken);
        return mapper.Map<LocationResponse>(location);
    }
}