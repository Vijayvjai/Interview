using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    public class OutputWriter : IOutput
    {
        /// <summary>
        /// Displays the strings
        /// </summary>
        /// <param name="data">String to be printed</param>
        public void WriteOutput(string data)
        {
            Console.WriteLine(data);
        }

        /// <summary>
        /// Displays the found pattern from Dictionary
        /// </summary>
        public void PrintPattern(Dictionary<string, int> patternByCount)
        {
            bool isPatternFound = false;

            foreach (var checkKey in patternByCount)
            {
                if (patternByCount.TryGetValue(checkKey.Key, out int value) && value > 1)
                {
                    Console.WriteLine("Pattern: {0} has occured {1} times.", checkKey.Key, value);
                    isPatternFound = true;
                }
            }

            if (isPatternFound == false)
            {
                Console.WriteLine("No Pattern Found");
            }
        }
    }
}
