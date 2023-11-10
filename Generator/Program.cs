// See https://aka.ms/new-console-template for more information
using PTSQL.SQL;
using PTSQL.SQL.Tables;

Console.WriteLine("Hello, World!");

List<SQLColumn> columns = new()
{
    new SQLColumn("Id"),
    new SQLColumn("LastLogin")
};

var resultTable = new SQLTableCommand(columns, "Users").Build();

Console.WriteLine("Program Finished Execution!");