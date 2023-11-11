using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PTSQL.Roslyn
{
    public static class SemanticAnalysisCompilation
    {
        private readonly static string DEFAULT_COMPILATION_NAME = "DEFAULT";

        private static CSharpCompilation CompilationInstance(SyntaxTree syntaxTree) =>
            CSharpCompilation.Create(DEFAULT_COMPILATION_NAME, syntaxTrees: new[] { syntaxTree });

        public static SemanticModel GetSemanticModel(this SyntaxTree syntaxTree) =>
            CompilationInstance(syntaxTree).GetSemanticModel(syntaxTree);

        public static Type? SymbolToType(this SemanticModel semanticModel, IPropertySymbol symbol)
        {
            var typeSymbol = symbol.Type;

            if(typeSymbol.DeclaringSyntaxReferences.Length == 0)
            {
                return null;
            }

            var typeSyntax = typeSymbol.DeclaringSyntaxReferences[0].GetSyntax().ToFullString();

            return Type.GetType(typeSyntax);
        }
    }
}
