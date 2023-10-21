namespace Metaphone.Data_Validation;

public class Validation
{
    public string ValidateEntry(string word)
    {
        string allowedChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        while (!word.All(allowedChar.Contains) || string.IsNullOrEmpty(word))
        {
            Console.WriteLine("\nOnly (a to z) English letters are accepted: \n");
            word = Console.ReadLine().ToUpper();
        }
        return word;
    }
}
