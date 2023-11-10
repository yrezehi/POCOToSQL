using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSQL.Extensions
{
    public static class EnumExtensions
    {
        public static string AsString(this Enum @enum) =>
            Enum.GetName(@enum.GetType(), @enum)!;
    }
}
