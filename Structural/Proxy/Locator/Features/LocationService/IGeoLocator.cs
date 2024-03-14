namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Features.LocationService;

public interface IGeoLocator
{
    Task<Location> GetAsync(string ipAddress, CancellationToken cancellationToken = default);
}
