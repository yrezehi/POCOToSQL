using Microsoft.CodeAnalysis.CSharp.Syntax;
using PTSQL.Loader;
using PTSQL.Loader.Variables;
using PTSQL.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSQL
{
    public static class Generator
    {

        // TODO: It shouldn't be class path bud
        public static void Generate(string classPath)
        {
            CompilationUnitSyntax unitSyntax = ClassLoader.Load(classPath);
            IEnumerable<Variable> variables = VariablesLoader.GetVariables(unitSyntax);
        }
    }
}
