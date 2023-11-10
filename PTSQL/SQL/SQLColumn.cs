namespace PTSQL.SQL
{
    public class SQLColumn
    {
        private readonly string ColumnName;
        private readonly SQLType Type;
        // minus max-length represent max
        private readonly int MaxLength = -1;
        private readonly bool IsNullable = true;

        public SQLColumn(string name, SQLType? type = null)
        {
            ColumnName = name;
            Type = type ?? SQLType.nvarchar;
        }
    }
}
