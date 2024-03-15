using System.Text;

namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs;

public static class StringExtensions
{
    public static string ToKebabCase(this string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        StringBuilder result = new();
        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                if (result.Length > 0 && result[result.Length - 1] != '-')
                    result.Append('-');
                result.Append(char.ToLower(c));
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}
