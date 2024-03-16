using System.Text;

namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.Extensions;

public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string input)
    {
        return string.IsNullOrEmpty(input);
    }

    public static string ToKebabCase(this string input)
    {
        if (input.IsNullOrEmpty())
            return input;

        StringBuilder result = new();
        foreach (var c in input)
        {
            if (c.IsLower())
            {
                result.Append(c);
                continue;
            }

            if (result.Length > 0 && result[result.Length - 1] != '-')
                result.Append('-');
            result.Append(c.ToLower());
        }


        return result.ToString();
    }
}