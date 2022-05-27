using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metaphone
{
    public class Vowels
    {
        public string VowelRemover(string word)
        {
            string[] vowels = new string[] { "A", "E", "I", "O", "U" };
            if (word.StartsWith('A') || word.StartsWith('E') || word.StartsWith('I') || word.StartsWith('O') || word.StartsWith('U') || word.StartsWith(' '))
            {
                char startingLetter = word[0];
                foreach (var letter in vowels)
                {
                    word = word.Replace(letter, string.Empty);
                }
                word = startingLetter.ToString() + word;
            }
            else
            {
                foreach (var letter in vowels)
                {
                    word = word.Replace(letter, string.Empty);
                }
            }
            return word;
        }
    }
}
