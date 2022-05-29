using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metaphone
{
    public class Transformation
    {
        DuplicatedConsonants adjacent = new DuplicatedConsonants();
        LetterExceptions exceptedletters = new LetterExceptions();
        Vowels vowels = new Vowels();
        Consonants consonants = new Consonants();
        string dropSilent;
        string consonantLetters;
        string vowelDrop;
        public string Filters(string word)
        {
            dropSilent = exceptedletters.DropBeginningSilentLetters(word);
            consonantLetters = consonants.ConsonantTransformer(dropSilent);
            vowelDrop = vowels.VowelRemover(consonantLetters);
            //var duplicate = adjacent.DuplicateRemover(vowelDrop);

            return vowelDrop;
        }
    }
}
