using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PTSQL.Loader.Projects
{
    public static class ProjectsLoader
    {
        public static async Task<Solution> Load(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($".sln was not found for {path}");
            }

            return await MSBuildWorkspace.Create().OpenSolutionAsync(path);
        }
    }
}
