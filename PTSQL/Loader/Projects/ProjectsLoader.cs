using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis;
namespace PTSQL.Loader.Projects
{
    public static class ProjectsLoader
    {
        public static async Task<Solution> Load(string path) =>
            await MSBuildWorkspace.Create().OpenSolutionAsync(path);
    }
}
