namespace Entry
{
    public class GeneratorInput
    {
        public IEnumerable<string> PathClasses { get; set; }

        private GeneratorInput(string[] paths) =>
            PathClasses = paths;

        public GeneratorInput GetInstanceOf(params string[] paths) =>
            new GeneratorInput(paths);
    }
}
