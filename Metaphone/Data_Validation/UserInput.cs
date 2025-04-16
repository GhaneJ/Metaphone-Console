namespace Metaphone.Data_Validation;

public class UserInput
{
    public static string[] SentenceFeeder(string[] sentence)
    {
        Console.SetCursorPosition(18, 8);
        Console.WriteLine("Enter a word or sentence to transform (Tap enter again to clear): \n");
        Console.Write("Input: ");
        sentence = Console.ReadLine().ToUpper().Split(' ');
        Console.Write("Output: ");

        return sentence;
    }
}