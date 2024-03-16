using Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Protocols.ResponseModels.Shared;

namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Extensions;

public static class PaginatedResponseExtensions
{
    public static PaginatedResponse<T> ToPaginatedResponse<T>(this IList<T> source, int pageNumber, int pageSize,
        int total)
    {
        return new PaginatedResponse<T>
        {
            Items = source,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalItems = total
        };
    }
}