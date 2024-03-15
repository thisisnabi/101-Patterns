namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Features.LocationService;

/// <summary>
/// Concrete implementation of IGeoLocator that fetches location data from an external API.
/// (This is the real subject in the Proxy Pattern)
/// </summary>
public class GeoLocatorApi(IMapper mapper, IOptions<LocationServiceAppSettings> locationServiceOptions) : IGeoLocator
{
    public const string LocatorName = "GeoLocatorAPI";

    public async Task<Location> GetAsync(string ipAddress, CancellationToken cancellationToken = default)
    {
        var settings = locationServiceOptions.Value;
        var httpClient = new HttpClient();
        var uri = new Uri($"{settings.IPGeoBaseUrl}?apiKey={settings.IPGeoApiKey}&ip={ipAddress}");

        var locatorResponse = await httpClient.GetFromJsonAsync<GeoLocationResponse>(uri, cancellationToken);

        if (locatorResponse is null)
            throw new UnableToConnectLocatorApiException();

        return mapper.Map<Location>(locatorResponse);
    }
}