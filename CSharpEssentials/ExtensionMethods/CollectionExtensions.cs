namespace CSharpEssentials.ExtensionMethods;

public static class CollectionExtensions
{
    public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T> collection)
    {
        return collection.Where(item => item != null);
    }
}