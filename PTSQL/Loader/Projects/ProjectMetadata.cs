using PTSQL.Loader.Variables;

namespace PTSQL.Loader.Classes
{
    public class ProjectMetadata
    {
        public IEnumerable<ClassMetadata> Classes { get; set; }

        private ProjectMetadata(IEnumerable<ClassMetadata> classes) =>
           (Classes) = (classes);

        public static ProjectMetadata Create(IEnumerable<ClassMetadata> classes) =>
            new ProjectMetadata(classes);
    }
}
