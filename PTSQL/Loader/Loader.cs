using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PTSQL.Loader.Classes;
using PTSQL.Loader.Projects;
using PTSQL.Loader.Variables;

namespace PTSQL.Loader
{
    public static class Loader
    {
        public static Task<Solution> LoadProject(string path) => 
            ProjectsLoader.Load(path);

        public static CompilationUnitSyntax Class(string path) =>
            ClassLoader.Load(path);

        public static IList<VariableMetadata> Variables(CompilationUnitSyntax compilationSyntaxTree) =>
            VariablesLoader.Get(compilationSyntaxTree);
    }
}
