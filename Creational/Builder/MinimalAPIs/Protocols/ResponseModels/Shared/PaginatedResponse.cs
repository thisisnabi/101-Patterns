namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Protocols.ResponseModels.Shared;

public sealed class PaginatedResponse<T>
{
    public IList<T> Items { get; set; } = null!;
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalItems { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);

    public bool IsNullOrEmpty()
    {
        return Items == null || Items.Any();
    }
}