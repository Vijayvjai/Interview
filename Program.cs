using System;
using System.Globalization;
using System.Threading;

namespace Interview
{
    class Program
    {
        /// <summary>
        /// Gets language selection, input & displays output
        /// </summary>
        static void Main(string[] args)
        {
            var factory = new PatternFinderFactory();

            var inputReader = factory.GetPattern<IInput>(InstanceTypes.Input);
            var outputter = factory.GetPattern<IOutput>(InstanceTypes.Output);

            outputter.WriteOutput("Choose Language English/French. Type EN (or) FR:");
            string lang = inputReader.ReadInput();

            if(string.Equals(lang, "en", StringComparison.OrdinalIgnoreCase))
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            }
            else if (string.Equals(lang, "fr", StringComparison.OrdinalIgnoreCase))
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            }

            outputter.WriteOutput(strings.InputString);
            string input = inputReader.ReadInput();

            outputter.WriteOutput(strings.PatternLength);
            if (int.TryParse(inputReader.ReadInput(), out var patternLength))
            {
                var patternFinder = factory.GetPattern<IPatternFinder>(InstanceTypes.Pattern);

                var output = patternFinder?.FindMatchPattern(input, patternLength);

                outputter.PrintPattern(output);
            }
            else
            {
                outputter.WriteOutput(strings.InputInteger);
            }
        }
    }
}
