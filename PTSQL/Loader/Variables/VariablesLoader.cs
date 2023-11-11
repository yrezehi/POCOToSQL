using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PTSQL.Roslyn;

namespace PTSQL.Loader.Variables
{
    public static class VariablesLoader
    {
        public static CompilationUnitSyntax GetVariables(CompilationUnitSyntax compilationSyntaxTree)
        {
            var variables = new List<Variable>();

            var declarations = compilationSyntaxTree.DescendantNodes().OfType<PropertyDeclarationSyntax>();
            var semanticModel = compilationSyntaxTree.SyntaxTree.GetSemanticModel();

            foreach (var declaration in declarations)
            {
                var declarationSymbol = semanticModel.GetDeclaredSymbol(declaration);

                variables.Add(Variable.Create(declarationSymbol.Name, declarationSymbol.Type));
            }

            return compilationSyntaxTree;
        }
    }
}
