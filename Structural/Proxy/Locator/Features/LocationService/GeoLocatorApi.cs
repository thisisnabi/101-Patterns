namespace Thisisnabi.DesignPattern.Structural.Locator.Features.LocationService;

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
        {
            throw new UnableToConnectLocatorApiException();
        }

        return mapper.Map<Location>(locatorResponse);
    }
}