namespace Metaphone.Results;

using Metaphone.Menu;

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
