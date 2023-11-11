using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace PTSQL.Roslyn
{
    public static class SemanticAnalysisCompilation
    {
        private readonly static string DEFAULT_COMPILATION_NAME = "DEFAULT";
        private readonly static string DEFAULT_TYPE_PREFIX = "System.";

        private static CSharpCompilation CompilationInstance(SyntaxTree syntaxTree) =>
            CSharpCompilation.Create(DEFAULT_COMPILATION_NAME, syntaxTrees: new[] { syntaxTree });

        public static SemanticModel GetSemanticModel(this SyntaxTree syntaxTree) =>
            CompilationInstance(syntaxTree).GetSemanticModel(syntaxTree);

        public static Type? SymbolToType(this IPropertySymbol semanticModelsymbol)
        {
            var typeSymbol = semanticModelsymbol.Type;

            return Type.GetType(DEFAULT_TYPE_PREFIX + typeSymbol.Name);
        }
    }
}
