using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSQL.Extensions
{
    public static class StringExtensions
    {
        public static string ToSnake(string @string) =>
            string.Join("_", @string.Split(' ', StringSplitOptions.RemoveEmptyEntries)).ToLower();
    }
}
