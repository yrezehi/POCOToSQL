using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSQL.Loader
{
    public class AttributesLoader
    {

        public CompilationUnitSyntax GetVariables(CompilationUnitSyntax syntaxTree)
        {
            IEnumerable<FieldDeclarationSyntax> declarations = syntaxTree.DescendantNodes().OfType<FieldDeclarationSyntax>();

            foreach (var declaration in declarations)
            {

            }

            return syntaxTree;
        }
    }
}
