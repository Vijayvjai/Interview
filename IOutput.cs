using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    public interface IOutput
    {
        /// <summary>
        /// Data to be displayed
        /// </summary>
        /// <param name="data">String to be printed</param>
        void WriteOutput(string data);

        /// <summary>
        /// Prints the matching pattern
        /// </summary>
        /// <param name="patternByCount">The dictionary to be printed</param>
        void PrintPattern(Dictionary<string, int> patternByCount);
    }
}
