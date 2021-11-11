using System;
using System.Collections.Generic;

namespace Interview
{
    class PatternFinder : IPatternFinder
    {
        /// <summary>
        /// To hold the matched pattern
        /// </summary>
        Dictionary<string, int> PatternByCount { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// Returns the matched pattern
        /// </summary>
        /// <param name="input">String to be searched for pattern</param>
        /// <param name="patternLength">Determined pattern length</param>
        public Dictionary<string, int> FindMatchPattern(string input, int patternLength)
        {
            string checkKey;

            for (int i = 0; i <= input.Length - patternLength; i++)
            {
                checkKey = input.Substring(i, patternLength);

                MatchPatternCount(checkKey);
            }

            return PatternByCount;
        }

        /// <summary>
        /// Populates the Dictionary
        /// </summary>
        /// <param name="checkKey">The key to be checked for</param>
        private void MatchPatternCount(string checkKey)
        {
            if (!PatternByCount.ContainsKey(checkKey))
            {
                PatternByCount.Add(checkKey, 1);
            }
            else
            {
                PatternByCount[checkKey]++;
            }
        }
    }
}
