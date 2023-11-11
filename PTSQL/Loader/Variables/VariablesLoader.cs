using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PTSQL.Roslyn;

namespace PTSQL.Loader.Variables
{
    public static class VariablesLoader
    {
        public static IList<Variable> GetVariables(CompilationUnitSyntax compilationSyntaxTree)
        {
            var variables = new List<Variable>();

            var declarations = compilationSyntaxTree.DescendantNodes().OfType<PropertyDeclarationSyntax>();
            var semanticModel = compilationSyntaxTree.SyntaxTree.GetSemanticModel();

            foreach (var declaration in declarations)
            {
                var declarationSymbol = semanticModel.GetDeclaredSymbol(declaration);

                if(declarationSymbol != null)
                {
                    var symbolType = declarationSymbol.SymbolToType();

                    if (symbolType != null)
                    {
                        variables.Add(Variable.Create(declarationSymbol.Name, symbolType));
                    }

                }
            }

            return variables;
        }
    }
}
