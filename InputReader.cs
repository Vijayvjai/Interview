using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    public class InputReader : IInput
    {
        /// <summary>
        /// Reads the input string
        /// </summary>
        /// <returns></returns>
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}
