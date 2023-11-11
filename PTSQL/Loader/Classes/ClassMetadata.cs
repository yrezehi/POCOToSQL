using PTSQL.Loader.Variables;

namespace PTSQL.Loader.Classes
{
    public class ClassMetadata
    {
        public string Name { get; set; }
        public IEnumerable<VariableMetadata> Variables { get; set; }

        private ClassMetadata(string name, IEnumerable<VariableMetadata> variables) =>
           (Name, Variables) = (name, variables);

        public static ClassMetadata Create(string name, IEnumerable<VariableMetadata> variables) =>
            new ClassMetadata(name, variables);
    }
}
