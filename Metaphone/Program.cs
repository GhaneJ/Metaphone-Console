using Metaphone.Data_Validation;
using Metaphone.Menu;
using Metaphone.Results;
using Metaphone.Transform_Rules;

Transformation transform = new();

string[] input, sentence = [];
string valid, transformed;

Menu.HUD_Directives();
do
{
    input = UserInput.SentenceFeeder(sentence);
    for (int i = 0; i < input.Length; i++)
    {
        valid = Validation.ValidateEntry(input[i]);
        transformed = transform.Filters(valid);
        Result.PrintResult(transformed);
    }

    ClearScreen.ClearCurrentConsoleLine();
} while (true);