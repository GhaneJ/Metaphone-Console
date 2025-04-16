namespace Metaphone.Transform_Rules;

public class Transformation
{
    // DuplicatedConsonants adjacent = new DuplicatedConsonants();
    string dropSilent;
    string consonantLetters;
    string vowelDrop;
    public string Filters(string word)
    {
        dropSilent = LetterExceptions.DropBeginningSilentLetters(word);
        consonantLetters = Consonants.Transform(dropSilent);
        vowelDrop = Vowels.VowelRemover(consonantLetters);
        //var duplicate = adjacent.DuplicateRemover(vowelDrop);

        return vowelDrop;
    }
}
