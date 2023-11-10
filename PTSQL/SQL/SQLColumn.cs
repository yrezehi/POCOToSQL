using PTSQL.Extensions;

namespace PTSQL.SQL
{
    public class SQLColumn
    {
        private string PropertyName;
        private readonly string ColumnName;
        private readonly SQLType Type;
        private readonly int MaxLength = -1;
        private readonly bool IsNullable = true;

        public SQLColumn(string name, int maxLength = -1, SQLType? type = null)
        {
            PropertyName = name;
            ColumnName = name.ToSnakeCase();
            Type = type ?? SQLType.nvarchar;
            MaxLength = maxLength;
        }
    }
}
