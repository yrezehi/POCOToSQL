// See https://aka.ms/new-console-template for more information
using PTSQL.Loader;
using PTSQL.Loader.Variables;
using PTSQL.SQL;
using PTSQL.SQL.Commands;

Console.WriteLine("Hello, World!");

List<SQLColumn> columns = new()
{
    new SQLColumn("Id"),
    new SQLColumn("LastLogin")
};

var resultTable = new SQLTableCommand(columns, "Users").Build();

var syntaxTree = ClassLoader.Load("C:\\Users\\Administrator\\Documents\\Projects\\Hisuh\\Hisuh\\Models\\Google\\GoogleMapsImage.cs");

VariablesLoader.GetVariables(syntaxTree);

Console.WriteLine("Program Finished Execution!");