namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Features.LocationService;

/// <summary>
/// Interface defining the contract for retrieving location data.
/// </summary>
public interface IGeoLocator
{
    /// <summary>
    /// Asynchronously retrieves location information for a given IP address.
    /// </summary>
    /// <param name="ipAddress">The IP address to query.</param>
    /// <param name="cancellationToken">A cancellation token for asynchronous operations.</param>
    /// <returns>A Task that resolves to a Location object containing the retrieved data.</returns>
    /// 
    Task<Location> GetAsync(string ipAddress, CancellationToken cancellationToken = default);
}
