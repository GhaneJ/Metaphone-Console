using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metaphone
{
    public class Vowels
    {
        public string[] VowelRemover(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                string[] vowels = new string[] { "A", "E", "I", "O", "U" };
                if (word[i].StartsWith('A') || word[i].StartsWith('E') || word[i].StartsWith('I') || word[i].StartsWith('O') || word[i].StartsWith('U') || word[i].StartsWith(' '))
                {
                    string startingLetter = word[i].Substring(0, 1);
                    foreach (var letter in vowels)
                    {
                        //word[i] = word[word[i].IndexOf(word[i].Substring(0, 1))];
                        word[i] = word[i].Replace(letter, string.Empty);
                    }
                    word[i] = startingLetter + word[i];
                }
                else
                {
                    foreach (var letter in vowels)
                    {
                        word[i] = word[i].Replace(letter, string.Empty);
                    }
                }
            }
            return word;
        }
    }
}
