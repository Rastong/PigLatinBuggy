using System;
using System.Collections.Generic;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input a word or sentence to translate to pig Latin");
            string input = Console.ReadLine().ToLower().Trim();
            Split_words s = new Split_words(input);
            TranslateToPigLatin T = new TranslateToPigLatin(input);
            List<string> FinalWords = s.DisplayList();
            string outPut = "";
            foreach (string f in FinalWords)
            {
                outPut += f + " ";
            }
            Console.WriteLine(outPut);
        }
    }
}
