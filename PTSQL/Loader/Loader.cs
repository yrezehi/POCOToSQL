using Microsoft.CodeAnalysis.CSharp.Syntax;
using PTSQL.Loader.Classes;
using PTSQL.Loader.Projects;
using PTSQL.Loader.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSQL.Loader
{
    public static class Loader
    {
        public static Task<MSLoader> LoadProject() => 
            ProjectsLoader.LoadProject();

        public static CompilationUnitSyntax Class(string path) =>
            ClassLoader.Load(path);

        public static IList<VariableMetadata> Variables(CompilationUnitSyntax compilationSyntaxTree) =>
            VariablesLoader.GetVariables(compilationSyntaxTree);
    }
}
