using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PTSQL.Roslyn;

namespace PTSQL.Loader.Classes
{
    public static class ClassLoader
    {
        public static CompilationUnitSyntax Load(string classPath)
        {
            if (!File.Exists(classPath))
            {
                throw new FileNotFoundException($"Class was not found for {classPath}");
            }

            return ParseClassSyntax(LoadAsText(classPath));
        }

        public static async Task<IEnumerable<ClassDeclarationSyntax>> LoadAll(Solution solution)
        {
            var classes = new List<ClassDeclarationSyntax>();

            foreach (var project in solution.Projects)
            {
                var compilation = project.GetCompilationAsync().GetAwaiter().GetResult();

                if (compilation != null)
                {
                    foreach (var syntaxTree in compilation.SyntaxTrees)
                    {
                        classes.AddRange(syntaxTree.GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>().ContainsAttribute("Table").ToList());
                    }
                }
            }
            
            return classes;
        }

        private static string LoadAsText(string classPath)
        {
            using (var streamReader = new StreamReader(classPath))
            {
                return streamReader.ReadToEnd();
            }
        }

        private static CompilationUnitSyntax ParseClassSyntax(string serializedClass) =>
            (CompilationUnitSyntax)CSharpSyntaxTree.ParseText(serializedClass).GetRoot();
    }
}
