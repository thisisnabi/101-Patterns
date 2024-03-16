namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Extensions;

public static class CharExtensions
{
    public static bool IsUpper(this char ch)
    {
        return char.IsUpper(ch);
    } 
    public static bool IsLower(this char ch)
    {
        return char.IsLower(ch);
    }
    public static char ToLower(this char ch)
    {
        return char.ToLower(ch);
    }
}