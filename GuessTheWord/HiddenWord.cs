using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessTheWord
{
    public class HiddenWord
    {
        // random objektot sluzi za prikazuvanje na random bukvi pri startuvanje na igrata
        Random random = new Random();
        public string Word { get; set; }
        // HashSet kade se chuvaat bukvite koj igracot treba da gi pogodi
        public HashSet<char> AllLetters { get; set; }
        // HashSet kade se chuvaat bukvite koj korisnikot vekje se otkrieni
        public HashSet<char> GivenLetters { get; set; }

        public HiddenWord(string word)
        {
            Word = word.ToUpper();
            AllLetters = new HashSet<char>();
            GivenLetters = new HashSet<char>();
            foreach (char c in Word)
            {
                if (random.Next(5) == 3)
                {
                    GivenLetters.Add(c);
                }
                if (!GivenLetters.Contains(c))
                {
                    AllLetters.Add(c);
                }
            }

            foreach (char c in GivenLetters.ToList())
            {
                foreach (char c1 in AllLetters.ToList())
                {
                    if (c == c1)
                    {
                        AllLetters.Remove(c1);
                    }
                }
            }
        }

        public string GetHiddenWord()
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            foreach (char c in Word)
            {
                if (GivenLetters.Contains(c))
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append("_");
                }
                sb.Append(' ');
            }
            return sb.ToString();
        }

        public void GuessLetter(char Letter)
        {
            Letter = Char.ToUpper(Letter);

            if (AllLetters.Contains(Letter) && !GivenLetters.Contains(Letter))
            {
                AllLetters.Remove(Letter);
                GivenLetters.Add(Letter);
            }
        }
    }
}
