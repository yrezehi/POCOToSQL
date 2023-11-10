namespace PTSQL.SQL.Commands
{
    public static class CommandConstants
    {
        public static string CREATE_TABLE(string tableName) =>
            $"CREATE TABLE [{tableName}]";

        public static string CLOSED_SCOPE(string command) =>
            $" ( {command} )";

        public static string COLUMN_NAME(string columnName) =>
            $"[{columnName}] ";

        public static string TABLE_NAME(string tableName) =>
            $"[{tableName}] ";
    }
}
