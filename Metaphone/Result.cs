using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metaphone
{
    public class Result
    {
        UI ui = new UI();
        public void PrintResult(string[] word)
        {
            foreach (var item in word)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
            Console.Clear();
            ui.HUD_Directives();
        }
    }
}
