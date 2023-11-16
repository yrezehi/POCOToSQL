using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PTSQL.Roslyn
{
    public static class UnitSyntax
    {
        public static ClassDeclarationSyntax? GetClassDeclaration(this CompilationUnitSyntax compilationSyntaxTree) =>
            compilationSyntaxTree.DescendantNodes().OfType<ClassDeclarationSyntax>().LastOrDefault();

        public static IEnumerable<ClassDeclarationSyntax> ContainsAttribute(this IEnumerable<ClassDeclarationSyntax> classDeclarations, string attributeName) =>
            classDeclarations.Where(declaration => declaration.AttributeLists.Any(attributeSyntax => attributeSyntax.Attributes.Any(attribute => attribute.Name.ToString() == attributeName)));

        public static string GetClassName(this ClassDeclarationSyntax declarationSyntax) =>
            declarationSyntax.Identifier.ToString();
    }
}
