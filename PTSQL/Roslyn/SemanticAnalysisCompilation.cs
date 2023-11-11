using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PTSQL.Roslyn
{
    public static class SemanticAnalysisCompilation
    {
        private readonly static string DEFAULT_COMPILATION_NAME = "DEFAULT";

        private static CSharpCompilation CompilationInstance =>
            CSharpCompilation.Create(DEFAULT_COMPILATION_NAME);

        public static SemanticModel GetSemanticModel(this CSharpSyntaxTree syntaxTree) =>
            CompilationInstance.GetSemanticModel(syntaxTree);

        public static INamedTypeSymbol? GetSemanticType(this SemanticModel semanticModel, TypeSyntax typeSyntax) =>
            semanticModel.GetDeclaredSymbol(typeSyntax) as INamedTypeSymbol;
    }
}
