namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs;

public static class CollectionExtensions
{
    public static IQueryable<T> ToPage<T>(this IQueryable<T> query, int index, int size)
         => query.Skip((index - 1) * size)
           .Take(size);

    public static bool IsNullOrEmpty<T>(this IEnumerable<T> values)
        => values == null || !values.Any();
}
