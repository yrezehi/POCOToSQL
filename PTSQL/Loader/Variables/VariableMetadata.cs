namespace PTSQL.Loader.Variables
{
    public class VariableMetadata
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public bool IsNullable { get; set; }

        private VariableMetadata(string name, Type type, bool isNullable = false) =>
           (Name, Type, IsNullable) = (name, type, isNullable);

        public static VariableMetadata Create(string name, Type type, bool isNullable = false) =>
            new VariableMetadata(name, type, isNullable);
    }
}
