using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSQL.Loader.Variables
{
    public static class VariablesLoader
    {

        public static CompilationUnitSyntax GetVariables(CompilationUnitSyntax syntaxTree)
        {
            var declarations = syntaxTree.DescendantNodes().OfType<PropertyDeclarationSyntax>();

            foreach (var declaration in declarations)
            {
                //Console.WriteLine(declaration);
            }

            return syntaxTree;
        }
    }
}
