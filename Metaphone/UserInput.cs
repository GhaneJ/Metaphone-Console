using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metaphone
{
    public class UserInput
    {
        public string[] SentenceFeeder(string[] sentence)
        {
            Console.SetCursorPosition(31, 8);
            Console.WriteLine("Enter a word or sentence to transform: ");
            sentence = Console.ReadLine().ToUpper().Split(' ');

            return sentence;
        }
    }
}
