namespace Interview
{
    /// <summary>
    /// Factory Class
    /// </summary>
    public class PatternFinderFactory
    {
        static IPatternFinder patternFinder;
        static IOutput outputFactory;
        static IInput inputFactory;

        /// <summary>
        /// Creates instances of PatternFinder,OutputWriter, InputReader
        /// </summary>
        /// <returns>Instance returned based on type passed</returns>
        public T GetPattern<T>(InstanceTypes args)
        {
            if (args == InstanceTypes.Pattern)
            {
                if (patternFinder == null)
                {
                    patternFinder = new PatternFinder();
                    return (T)patternFinder;
                }
                return (T)patternFinder;
            }
            if (args == InstanceTypes.Output)
            {
                if (outputFactory == null)
                {
                    outputFactory = new OutputWriter();
                    return (T)outputFactory;
                }
                return (T)outputFactory;
            }
            if (args == InstanceTypes.Input)
            {
                if (inputFactory == null)
                {
                    inputFactory = new InputReader();
                    return (T)inputFactory;
                }
                return (T)inputFactory;
            }
            return default;
        }
    }
}
