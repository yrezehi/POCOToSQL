using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PTSQL.Roslyn;

namespace PTSQL.Loader.Variables
{
    public static class VariablesLoader
    {
        public static CompilationUnitSyntax GetVariables(CompilationUnitSyntax compilationSyntaxTree)
        {
            var declarations = compilationSyntaxTree.DescendantNodes().OfType<PropertyDeclarationSyntax>();
            var semanticModel = compilationSyntaxTree.SyntaxTree.GetSemanticModel();

            foreach (var declaration in declarations)
            {
                var declarationSymbol = semanticModel.GetDeclaredSymbol(declaration);
                
                var declarationType = declarationSymbol.Type;
                var declarationName = declarationSymbol.Name;
            }

            return compilationSyntaxTree;
        }
    }
}
