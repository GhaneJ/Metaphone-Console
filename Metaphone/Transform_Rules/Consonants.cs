namespace Metaphone.Transform_Rules;

public static class Consonants
{
    public static string Transform(string word)
    {
        if (string.IsNullOrWhiteSpace(word) || word.Length == 1)
            return word;

        word = TransformB(word);
        word = TransformC(word);
        word = TransformD(word);
        word = TransformG(word);
        word = TransformH(word);
        word = TransformP(word);
        word = TransformQ(word);
        word = TransformS(word);
        word = TransformT(word);
        word = TransformV(word);
        word = TransformW(word);
        word = TransformX(word);
        word = TransformY(word);
        word = TransformZ(word);

        return word;
    }

    private static string TransformB(string word)
    {
        if (word.EndsWith("MB"))
        {
            int index = word.LastIndexOf('B');
            word = word.Remove(index, 1);
        }
        return word;
    }

    private static string TransformC(string word)
    {
        if (word.Contains("CIA"))
            return word.Replace("C", "X");

        if (word.Contains("CH"))
            return word.Replace("CH", "X");

        if (word.Contains("CI") || word.Contains("CE") || word.Contains("CY"))
            return word.Replace('C', 'S');

        if (word.Contains("CK"))
            word = word.Remove(word.IndexOf("C"), 1);

        return word.Replace('C', 'K');
    }

    private static string TransformD(string word)
    {
        if (word.Contains("DGE") || word.Contains("DGI") || word.Contains("DGY"))
        {
            word = word.Replace('D', 'J');
            int gIndex = word.IndexOf('G');
            if (gIndex >= 0)
                word = word.Remove(gIndex, 1);
        }
        else
        {
            word = word.Replace('D', 'T');
        }

        return word;
    }

    private static string TransformG(string word)
    {
        if (word.Contains("GN") || word.Contains("GNED"))
        {
            int gIndex = word.IndexOf("G");
            if (gIndex >= 0)
                word = word.Remove(gIndex, 1);
        }

        if (word.Contains("GI") || word.Contains("GE") || word.Contains("GY"))
        {
            return word.Replace('G', 'J');
        }

        return word.Replace('G', 'K');
    }

    private static string TransformH(string word)
    {
        if (word.EndsWith("GH"))
            return word;

        string[] patterns = { "GH", "AH", "EH", "IH", "OH", "UH" };
        foreach (var p in patterns)
        {
            if (word.Contains(p))
            {
                int hIndex = word.IndexOf("H");
                if (hIndex >= 0)
                    word = word.Remove(hIndex, 1);
                break;
            }
        }

        return word;
    }

    private static string TransformP(string word)
    {
        return word.Replace("PH", "F");
    }

    private static string TransformQ(string word)
    {
        return word.Replace("Q", "K");
    }

    private static string TransformS(string word)
    {
        if (word.Contains("SIA") || word.Contains("SIO") || word.Contains("SH"))
        {
            return word.Replace("S", "X");
        }

        return word;
    }

    private static string TransformT(string word)
    {
        if (word.Contains("TIA") || word.Contains("TIO"))
        {
            return word.Replace("T", "X");
        }

        if (word.Contains("TH"))
        {
            return word.Replace("TH", "0");
        }

        if (word.Contains("TCH"))
        {
            int tIndex = word.IndexOf("TCH");
            if (tIndex >= 0)
                word = word.Remove(tIndex, 1);
        }

        return word;
    }

    private static string TransformV(string word)
    {
        return word.Replace("V", "F");
    }

    private static string TransformW(string word)
    {
        if (word.Contains("WA") || word.Contains("WE") || word.Contains("WI") || word.Contains("WO") || word.Contains("WU"))
            return word;

        int wIndex = word.IndexOf("W");
        if (wIndex >= 0)
            word = word.Remove(wIndex, 1);

        return word;
    }

    private static string TransformX(string word)
    {
        return word.Replace("X", "KS");
    }

    private static string TransformY(string word)
    {
        if (word.Contains("YA") || word.Contains("YE") || word.Contains("YI") || word.Contains("YO") || word.Contains("YU"))
            return word;

        int yIndex = word.IndexOf("Y");
        if (yIndex >= 0)
            word = word.Remove(yIndex, 1);

        return word;
    }

    private static string TransformZ(string word)
    {
        return word.Replace("Z", "S");
    }
}