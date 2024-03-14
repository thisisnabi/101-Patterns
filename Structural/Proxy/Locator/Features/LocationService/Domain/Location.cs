namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Features.LocationServices.Domain;

public class Location
{
    public const string TableName = "Locations";

    public required string IP { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public required string ContinentName { get; set; }

    public required string CountryName { get; set; }

    public required string CountryCode { get; set; }

    public required string State { get; set; }

    public required string City { get; set; }

    public required string CallingCode { get; set; }

}
