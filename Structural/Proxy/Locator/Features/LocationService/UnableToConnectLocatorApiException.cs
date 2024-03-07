namespace Thisisnabi.DesignPattern.Structural.Locator.Features.LocationService;

public sealed class UnableToConnectLocatorApiException : Exception
{
    private const string _message = "Currently, the location inquiry service is not available.";

    public UnableToConnectLocatorApiException() : base(_message)
    {
        
    }
}
