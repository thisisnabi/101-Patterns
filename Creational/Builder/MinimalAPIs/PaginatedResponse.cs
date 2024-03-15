namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs;

public class PaginatedResponse<T>
{
    public IList<T> Items { get; set; } = null!;
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalItems { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);
    public bool IsNullOrEmpty() => Items == null || Items.Any();
}


public static class PaginatedResponse
{
    public static PaginatedResponse<T> ToPaginatedResponse<T>(this IList<T> source, int pageNumber, int pageSize, int total)
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