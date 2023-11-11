using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSQL.Roslyn
{
    public static class UnitSyntax
    {
        public static ClassDeclarationSyntax? GetClassDeclaration(this CompilationUnitSyntax compilationSyntaxTree) =>
            compilationSyntaxTree.DescendantNodes().OfType<ClassDeclarationSyntax>().LastOrDefault();

        public static string GetClassName(this ClassDeclarationSyntax declarationSyntax) =>
            declarationSyntax.Identifier.ToString();
    }
}
