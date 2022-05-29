using Metaphone;

UI ui = new UI();
UserInput wordList = new UserInput();
Validation validation = new Validation();
Transformation transform = new Transformation();
Result result = new Result();

string[] input, sentence = Array.Empty<string>();
string valid, transformed;

ui.HUD_Directives();
do
{
    input = wordList.SentenceFeeder(sentence);
    for (int i = 0; i < input.Length; i++)
    {
        valid = validation.ValidateEntry(input[i]);
        transformed = transform.Filters(valid);
        result.PrintResult(transformed);
    }
    
    ClearScreen.ClearCurrentConsoleLine();
} while (true);