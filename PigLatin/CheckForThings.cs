using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class CheckForThings
    {
        public string Word { get; set; }

        public CheckForThings(string word)
        {
            Word = word;
        }

        public bool CheckForSpecialChar()
        {
            bool OutPut = true;
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            foreach (char c in specialChars)
            {
                if (Word.Contains(c))
                {
                    Console.WriteLine("That word has special characters, we will return it as is");
                    return false;
                }
            }
            return OutPut;
        }

        public bool IsVowel()
        {
            bool StartsVowel = true;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            foreach (char c in vowels)
            {
                if (Word.StartsWith(c))
                {
                    StartsVowel = false;
                }
            }
            return StartsVowel;
        }
    }
}
