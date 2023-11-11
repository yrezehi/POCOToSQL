using Microsoft.CodeAnalysis.CSharp.Syntax;
using PTSQL.Loader.Classes;
using PTSQL.Loader.Variables;
using PTSQL.SQL;
using PTSQL.SQL.Commands;

namespace PTSQL
{
    public static class Generator
    {

        // TODO: It shouldn't be class path bud
        public static void GenerateTable(string classPath)
        {
            CompilationUnitSyntax unitSyntax = ClassLoader.Load(classPath);
            IEnumerable<VariableMetadata> variables = VariablesLoader.GetVariables(unitSyntax);

            IEnumerable<SQLColumn> columns = variables.Select(variable =>
                SQLColumn.Create(variable.Name, type: variable.Type)
            );

            SQLTableCommand.GetInstance("");
        }
    }
}
