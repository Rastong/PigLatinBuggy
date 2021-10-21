using System;

namespace PigLatin
{
    class TranslateToPigLatin
    {
        //Properties
        public string Word { get; set; }
        //Constructor
        public TranslateToPigLatin(string word)
        {
            Word = word;
        }
        //Method
        public string ToPigLatin()
        {
            string FinalWord = "";
            TranslateToPigLatin TBTranslated = new TranslateToPigLatin(Word);
            CheckForThings Checked = new CheckForThings(Word);
            bool Symbols = true;
            bool FirstLetterVowel = false;
            Symbols = Checked.CheckForSpecialChar();
            if (Symbols == false)
            {
                return Word;
            }
            FirstLetterVowel = Checked.IsVowel();
            if (FirstLetterVowel == false)
            {
                return Word + "ay";
            }
            FinalWord = TBTranslated.CovertToPig();
            return FinalWord;
        }

        public string CovertToPig()
        {
            int i = 0;
            string FrontEnd = "";
            string Translated = "";
            string[] vowels = { "a","e","i","o","u" };
            foreach (string c in vowels)
            {
                for (i = 0; i < Word.Length; i++)
                {
                    if (Word.Substring(i, 1) == c)
                    {
                        FrontEnd = Word.Substring(i);
                        Translated = Word.Substring(0, i);
                        break;
                    }
                }
            }
            return FrontEnd + Translated + "way";
        }

       
    }
}
