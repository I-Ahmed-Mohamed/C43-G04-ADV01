using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    using System;
    using System.Collections.Generic;

    public class FirstNonRepeatedCharacter
    {
        public static int FindFirstNonRepeatedCharacterIndex(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count the occurrence of each character
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Find the first character with a count of 1
            for (int i = 0; i < input.Length; i++)
            {
                if (charCount[input[i]] == 1)
                {
                    return i;
                }
            }

            return -1; // Return -1 if no non-repeated character is found
        }
    }
}
