using Microsoft.CodeAnalysis.CSharp.Syntax;
using PTSQL.Loader.Classes;
using PTSQL.Loader.Variables;
using PTSQL.Roslyn;
using PTSQL.SQL;
using PTSQL.SQL.Commands;

namespace PTSQL
{
    public static class Generator
    {
        // TODO: It shouldn't be class path bud
        public static string GenerateTable(string classPath)
        {
            CompilationUnitSyntax unitSyntax = ClassLoader.Load(classPath);
            List<VariableMetadata> variables = VariablesLoader.Get(unitSyntax);

            string className = unitSyntax.GetClassDeclaration()!.GetClassName();

            variables.PrintMetadata(className);

            SQLTableCommand command = SQLTableCommand.GetInstance(
                className,
                variables.Select(variable =>
                    SQLColumn.Create(variable.Name, type: variable.Type)
                )
            );

            return command.Build();
        }

        public static void PrintMetadata(this List<VariableMetadata> variables, string className)
        {
            Console.WriteLine("[METADATA] Found class fields for " + className);
            variables.ForEach(variable => {
                Console.Write("\n\t" + variable.Name + " - " + variable.Type + "\n");
            });
        }
    }
}
