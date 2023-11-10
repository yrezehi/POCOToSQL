using PTSQL.Extensions;

namespace PTSQL.SQL
{
    public class SQLColumn
    {
        public string PropertyName;
        public readonly string ColumnName;
        public readonly SQLType Type;
        public readonly int MaxLength = -1;
        public readonly bool IsNullable = true;

        public SQLColumn(string name, int maxLength = -1, SQLType? type = null)
        {
            PropertyName = name;
            ColumnName = name.ToSnakeCase();
            Type = type ?? SQLType.nvarchar;
            MaxLength = maxLength;
        }

        public string DataType =>
            Type.AsString();

        public string Length => 
            MaxLength == -1 ? " MAX " : MaxLength.ToString();

        public string Nullability =>
            IsNullable ? " NULL " : " NOT NULL ";
     }
}
