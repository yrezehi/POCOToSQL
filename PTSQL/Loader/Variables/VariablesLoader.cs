using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PTSQL.Roslyn;

namespace PTSQL.Loader.Variables
{
    public static class VariablesLoader
    {
        public static List<VariableMetadata> Get(CompilationUnitSyntax compilationSyntaxTree)
        {
            var variables = new List<VariableMetadata>();

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
                        variables.Add(VariableMetadata.Create(declarationSymbol.Name, symbolType));
                    }

                }
            }

            return variables;
        }
    }
}
