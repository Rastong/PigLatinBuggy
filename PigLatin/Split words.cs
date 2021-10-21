using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigLatin
{
    class Split_words
    {
        public List<TranslateToPigLatin> TranslateToPig { get; set; }

        public Split_words(string words)
        {
            List<string> Break = words.Split(" ").ToList();
            TranslateToPig = new List<TranslateToPigLatin>();
            foreach (string s in Break)
            {
                TranslateToPig.Add(new TranslateToPigLatin(s));
            }
        }

        public List<string> DisplayList()
        {
            List<string> outCome = new List<string>();
            foreach (TranslateToPigLatin P in TranslateToPig)
            {
                outCome.Add(P.ToPigLatin());
            }
            return outCome;
        }
    }
}
