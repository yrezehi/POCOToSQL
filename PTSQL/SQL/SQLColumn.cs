using PTSQL.Extensions;

namespace PTSQL.SQL
{
    public class SQLColumn
    {
        public string PropertyName;
        public readonly string ColumnName;

        public readonly SQLType? SType;
        public readonly Type? Type; 

        public readonly int MaxLength = -1;
        public readonly bool IsNullable = true;

        public SQLColumn(string name, int maxLength = -1, SQLType? type = null)
        {
            PropertyName = name;
            ColumnName = name.ToSnakeCase();
            SType = type;
            MaxLength = maxLength;
        }

        public SQLColumn(string name, int maxLength = -1, Type? type = null)
        {
            PropertyName = name;
            ColumnName = name.ToSnakeCase();
            Type = type;
            MaxLength = maxLength;
        }

        public static SQLColumn Create(string name, int maxLength, Type type) =>
            new SQLColumn(name, maxLength, type);

        public static SQLColumn Create(string name, int maxLength, SQLType type) =>
            new SQLColumn(name, maxLength, type);

        public string DataType =>
            SType == null ? SQLTypeMapper.ToSQLType(Type!).AsString() : SType.AsString();

        public string Length => 
            MaxLength == -1 ? " MAX " : MaxLength.ToString();

        public string Nullability =>
            IsNullable ? " NULL " : " NOT NULL ";
     }
}
