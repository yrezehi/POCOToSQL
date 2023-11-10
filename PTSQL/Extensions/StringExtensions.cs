namespace PTSQL.Extensions
{
    public static class StringExtensions
    {
        public static string ToSnakeCase(this string @string) =>
            string.Join("_", @string.Split(' ', StringSplitOptions.RemoveEmptyEntries)).ToLower();
    }
}
