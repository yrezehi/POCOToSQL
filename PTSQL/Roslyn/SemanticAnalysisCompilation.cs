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
    }
}
