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

        private readonly static string DEFAULT_SCHEMA_NAME = "";

        public SQLTableWriter(string tableName, string? schemaName = null) =>
            (TableName, SchemaName) = (tableName, schemaName ?? DEFAULT_SCHEMA_NAME);

        public string Build()
        {
            return base.ToString();
        }

    }
}
