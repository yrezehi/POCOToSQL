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

        public SQLColumn(string name, int maxLength = -1, SQLType? type = null, bool isNullable = true)
        {
            PropertyName = name;
            ColumnName = name.ToSnakeCase();
            SType = type;
            MaxLength = maxLength;
            IsNullable = isNullable;
        }

        public SQLColumn(string name, int maxLength = -1, Type? type = null, bool isNullable = true)
        {
            PropertyName = name;
            ColumnName = name.ToSnakeCase();
            Type = type;
            MaxLength = maxLength;
            IsNullable = isNullable;
        }

        public static SQLColumn Create(string name, Type type, int maxLength = -1, bool isNullable = true) =>
            new SQLColumn(name, maxLength: maxLength, type: type, isNullable: isNullable);

        public static SQLColumn Create(string name, SQLType type, int maxLength = -1, bool isNullable = true) =>
            new SQLColumn(name, maxLength: maxLength, type: type, isNullable: isNullable);

        public string DataType =>
            SType == null ? SQLTypeMapper.ToSQLType(Type!).AsString() : SType.AsString();

        public string Length => 
            MaxLength == -1 ? " MAX " : MaxLength.ToString();

        public string Nullability =>
            IsNullable ? " NULL " : " NOT NULL ";
     }
}
