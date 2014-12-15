using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abc12defgh";
            Console.WriteLine(AllUniqueChars(s));
            Console.Read();
        }

        /// <summary>
        /// Check if the given string has all unique characters
        /// assuming it is an (extended) ASCII string
        /// </summary>
        /// <param name="str">string to be checked</param>
        /// <returns>true if all characters are unique and false otherwise</returns>
        static bool AllUniqueChars(string str)
        {
            const short asciiLength = 256;
            // Length cannot be > 256 without having duplicate characters for an (extended) ASCII string
            if (str.Length > asciiLength) return false;

            var ithCharPresent = new bool[asciiLength];
            foreach (var c in str)
            {
                if (ithCharPresent[c]) return false;
                ithCharPresent[c] = true;
            }
            return true;
        }
    }
}
