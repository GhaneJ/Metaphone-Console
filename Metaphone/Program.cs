using Metaphone;

UI ui = new UI();
UserInput wordList = new UserInput();
Validation validation = new Validation();
Transformation transform = new Transformation();
Result result = new Result();

string[] sentence = Array.Empty<string>();
ui.HUD_Directives();
do
{
    string[] input = wordList.SentenceFeeder(sentence);
    string[] valid = validation.ValidateEntry(input);
    string[] transformed = transform.ConsonantTransformer(valid);
    result.PrintResult(transformed);
    
    Console.WriteLine("\n");
} while (true);