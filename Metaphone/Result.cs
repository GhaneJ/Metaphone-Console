using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metaphone
{
    public class Result
    {
        public void PrintResult(string word)
        {
            foreach (var item in word)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\nPress a key...");
            Console.ReadKey();
            ClearScreen.ClearCurrentConsoleLine();

        }
    }
}
