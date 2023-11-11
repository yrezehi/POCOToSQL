namespace PTSQL.SQL
{
    public static class SQLTypeMapper
    {
        private static readonly Dictionary<SQLType, Type> MapperDicionarySTP = new() {
            { SQLType.bigint, typeof(long) },
            { SQLType.bit, typeof(bool) },
            { SQLType.@char, typeof(string) },
            { SQLType.date, typeof(DateTime) },
            { SQLType.datetime, typeof(DateTime) },
            { SQLType.datetime2, typeof(DateTime) },
            { SQLType.datetimeoffset, typeof(DateTimeOffset) },
            { SQLType.@decimal, typeof(decimal) },
            { SQLType.@float, typeof(double) },
            { SQLType.@float, typeof(float) },
            { SQLType.@int, typeof(int) },
            { SQLType.money, typeof(decimal) },
            { SQLType.nchar, typeof(string) },
            { SQLType.nvarchar, typeof(string) },
            { SQLType.varchar, typeof(string) },
            { SQLType.real, typeof(float) },
            { SQLType.smalldatetime, typeof(DateTime) },
            { SQLType.smallint, typeof(short) },
            { SQLType.time, typeof(TimeSpan) },
            { SQLType.tinyint, typeof(byte) },
        };

        private static readonly Dictionary<Type, SQLType> MapperDicionary = new() {
            { typeof(long), SQLType.bigint },
            { typeof(bool), SQLType.bit },
            { typeof(string), SQLType.@char },
            { typeof(DateTime), SQLType.datetime },
            { typeof(decimal), SQLType.@decimal },
            { typeof(float), SQLType.@float },
            { typeof(int), SQLType.@int },
            { typeof(string), SQLType.nvarchar },
            { typeof(short), SQLType.smallint },
            { typeof(byte), SQLType.tinyint },
        };

        public static SQLType ToSQLType(this Type type)
        {
            if (MapperDicionary.ContainsKey(type))
            {
                return MapperDicionary[type];
            }

            return SQLType.nvarchar;
        }

        public static Type ToType(this SQLType type)
        {
            if (MapperDicionarySTP.ContainsKey(type))
            {
                return MapperDicionarySTP[type];
            }

            return typeof(string);
        } 
    }
}
