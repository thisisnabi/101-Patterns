
namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Protocols.RequestModels.Shared;

public sealed class PagedRequestQuery
{
    [FromQuery] public int Page { get; set; } = 1;

    [FromQuery] public int Size { get; set; } = 10;
}