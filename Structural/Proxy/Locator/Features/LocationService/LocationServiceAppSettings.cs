namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Features.LocationService;

public sealed class LocationServiceAppSettings
{
    public const string SectionName = "LocationService";

    public required string IPGeoApiKey { get; set; }

    public required string IPGeoBaseUrl { get; set; }
}
