using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

        public static CompilationUnitSyntax LoadInstance(string classPath)
        {
            var unitSyntax = ClassLoader.Load(classPath);

            var classDeclaration = unitSyntax.DescendantNodes().OfType<ClassDeclarationSyntax>().LastOrDefault();

            if (classDeclaration == null)
            {
                throw new ArgumentException("No Class Declaration Was Found!");
            }

            return ClassMetadata.Create(CLA);
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
