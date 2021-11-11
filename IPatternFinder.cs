using System.Collections.Generic;

namespace Interview
{

    public interface IPatternFinder
    {
        /// <summary>
        /// Finds the matching pattern in input by patternLength
        /// </summary>
        /// <param name="input">Given string </param>
        /// <param name="patternLength">Specified pattern length</param>
        /// <returns>Dictionary with matching pattern</returns>
        Dictionary<string, int> FindMatchPattern(string input, int patternLength);
    }
}
