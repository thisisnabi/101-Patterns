namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Features.LocationService;
/// <summary>
/// Custom exception thrown when unable to connect to the location service.
/// </summary>
public sealed class UnableToConnectLocatorApiException : Exception
{
    private const string _message = "Currently, the location inquiry service is not available.";

    public UnableToConnectLocatorApiException() : base(_message)
    {
        
    }
}
