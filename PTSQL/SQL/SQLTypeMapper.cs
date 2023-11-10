using System.Data;

namespace PTSQL.SQL
{
    public class SQLTypeMapper


        public static readonly Dictionary<SqlDbType, Type> MapperDicionary = new() {
            { bigint, typeof(long) },
            { bit, typeof(long) },
            { @char, typeof(long) },
            { date, typeof(long) },
            { datetime, typeof(long) },
            { datetime2, typeof(long) },
            { datetimeoffset, typeof(long) },
            { @decimal, typeof(long) },
            { @float, typeof(long) },
            { @int, typeof(long) },
            { money, typeof(long) },
            { nchar, typeof(long) },
            { nvarchar, typeof(long) },
            { real, typeof(long) },
            { smalldatetime, typeof(long) },
            { smallint, typeof(long) },
            { time, typeof(long) },
            { tinyint, typeof(long) },
            { varchar, typeof(long) },
        };
}
