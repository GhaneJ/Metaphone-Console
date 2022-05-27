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
        public string ConsonantTransformer(string word)
        {  
            
            var dropSilent = exceptedletters.DropBeginningSilentLetters(word);
            var consonantLetters = consonants.ConsonantTransformer(dropSilent);
            var vowelDrop = vowels.VowelRemover(consonantLetters);
            //var duplicate = adjacent.DuplicateRemover(vowelDrop);
            return vowelDrop;
        }
    }
}
