namespace PTSQL.SQL.Commands
{
    public static class CommandConstants
    {
        public static string CREATE_TABLE(string tableName) =>
            $"CREATE TABLE [{tableName}]";
    }
}
