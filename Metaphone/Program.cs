using Metaphone;

UI ui = new UI();
Validation validation = new Validation();
Transformation transform = new Transformation();

ui.HUD_Directives();
do
{
    Console.Write("\nEnter a word containing english letters (a-z)): ");
    string word = Console.ReadLine().ToUpper();
    var valid = validation.ValidateEntry(word);
    var transformed = transform.ConsonantTransformer(valid);
    Console.WriteLine($"\n {word} --> {transformed}");
} while (true);