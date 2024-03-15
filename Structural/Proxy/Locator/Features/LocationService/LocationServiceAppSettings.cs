namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Features.LocationService;

/// <summary>
/// Class for storing application settings related to the location service.
/// </summary>
public sealed class LocationServiceAppSettings
{
    public const string SectionName = "LocationService";

    public required string IPGeoApiKey { get; set; }

    public required string IPGeoBaseUrl { get; set; }
}
