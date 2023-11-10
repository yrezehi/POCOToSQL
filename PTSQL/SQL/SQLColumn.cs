namespace PTSQL.SQL
{
    public class SQLColumn
    {
        private readonly string ColumnName;
        private readonly SQLType Type;
        private readonly int MaxLength = -1;
        private readonly bool IsNullable = true;

        public SQLColumn(string name, int maxLength = -1, SQLType? type = null)
        {
            ColumnName = name;
            Type = type ?? SQLType.nvarchar;
            MaxLength = maxLength;
        }
    }
}
