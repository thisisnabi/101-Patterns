using Microsoft.AspNetCore.Mvc;

namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs;

public class PagedRequestQuery
{
    [FromQuery]
    public int Page { get; set; } = 1;

    [FromQuery]
    public int Size { get; set; } = 10;
}
