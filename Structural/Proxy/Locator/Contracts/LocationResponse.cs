namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Contracts;


/// <summary>
/// Interface defining the contract for retrieving location data.
/// </summary>
public record class LocationResponse(
       double Latitude,
       double Longitude,
       string ContinentName,
       string CountryName,
       string CountryCode,
       string State,
       string City,
       string CallingCode);
