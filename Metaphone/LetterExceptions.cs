using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metaphone
{
    public class LetterExceptions
    {
        public string[] DropBeginningSilentLetters(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {

                // Since "ac" starts with 'a' and 'a' is a vowel and removing
                // a vowel from the beginning violates our rules, so it will be
                // exempted from this method. ex. Acclaim, accept => aclm, acpt

                if (word[i].StartsWith("KN") || word[i].StartsWith("GN") || word[i].StartsWith("PN") || word[i].StartsWith("WR"))
                {
                    int drop = word[i].IndexOf(word[i].Substring(0, 1));
                    word[i] = word[i].Remove(drop, 1);

                }
                if (word[i].StartsWith('X'))
                {
                    word[i] = word[i].Replace('X', 'S');
                }
                if (word[i].StartsWith("WH"))
                {
                    int drop = word[i].IndexOf(word[i].Substring(1, 1));
                    word[i] = word[i].Remove(drop, 1);
                }
            }
            return word;
        }
    }
}
