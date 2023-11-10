using PTSQL.SQL.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSQL.SQL.Tables
{
    public class SQLTableCommand
    {
        private readonly string TableName;
        private readonly string SchemaName;

        private readonly IEnumerable<SQLColumn> Columns;

        private readonly static string DEFAULT_SCHEMA_NAME = "";

        public SQLTableCommand(IEnumerable<SQLColumn> columns, string tableName, string? schemaName = null) =>
            (Columns, TableName, SchemaName) = (columns, tableName, schemaName ?? DEFAULT_SCHEMA_NAME);

        public string Build()
        {
            StringBuilder command = new StringBuilder();

            command.AppendLine(CommandConstants.CREATE_TABLE(TableName));
            command.AppendLine(CommandConstants.CLOSED_SCOPE(BuildColumns()));

            return command.ToString();
        }

        private string BuildColumns()
        {
            StringBuilder command = new StringBuilder(); 

            foreach (var column in Columns)
            {
                command.Append(CommandConstants.COLUMN_NAME(column.ColumnName));
                command.Append(column.DataType);
                command.Append(column.Length);
                command.Append(column.Nullability);
            }

            return command.ToString();
        }

    }
}
