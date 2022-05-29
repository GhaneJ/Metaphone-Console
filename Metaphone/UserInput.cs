using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metaphone
{
    public class UserInput
    {
        //UI ui = new UI();
        public string[] SentenceFeeder(string[] sentence)
        {
            Console.SetCursorPosition(18, 8);
            Console.WriteLine("Enter a word or sentence to transform (Tap enter again to clear): \n");
            Console.Write("Input: ");
            sentence = Console.ReadLine().ToUpper().Split(' ');
            Console.Write("Output: ");

            return sentence;
        }
    }
}
