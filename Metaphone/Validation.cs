using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Metaphone
{
    public class Validation
    {
        public string ValidateEntry(string word)
        {

            string allowedChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            while (!word.All(allowedChar.Contains) || String.IsNullOrEmpty(word))
                {                
                Console.WriteLine("\nOnly (a to z) English letters are accepted: \n");
                Console.Write("\nTry a new word: ");
                word = Console.ReadLine().ToUpper();
            }
                return word;
        }
    }
}
