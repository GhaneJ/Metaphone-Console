using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metaphone
{
    public class Consonants
    {
        public string[] ConsonantTransformer(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                while (!String.IsNullOrEmpty(word[i]))
                {

                    if (word[i].EndsWith('B') && word[i][word[i].IndexOf('B') - 1] == 'M')
                    {
                        word[i] = word[i].Remove(word[i].IndexOf('B'), 1);
                    }

                    if (word[i].Contains("CK"))
                    {
                        word[i] = word[i].Remove(word[i].IndexOf('C'), 1);
                    }

                    if (word.Contains("CIA"))
                    {
                        word[i] = word[i].Replace("C", "X");
                    }

                    if (word[i].Contains("CH"))
                    {
                        word[i] = word[i].Replace("CH", "X");
                    }

                    if (word[i].Contains("CI") || word.Contains("CE") || word.Contains("CY"))
                    {
                        word[i] = word[i].Replace('C', 'S');
                    }

                    else if (word[i].Contains('C'))
                    {
                        word[i] = word[i].Replace('C', 'K');
                    }

                    if (word[i].Contains("DGE") || word[i].Contains("DGI") || word[i].Contains("DGY"))
                    {
                        word[i] = word[i].Replace('D', 'J');
                        word[i] = word[i].Remove(word[i].IndexOf('G'), 1);
                    }

                    else if (word[i].Contains('D'))
                    {
                        word[i] = word[i].Replace('D', 'T');
                    }

                    if (word[i].Contains("GN") || word[i].Contains("GNED"))
                    {
                        word[i] = word[i].Remove(word[i].IndexOf('G'), 1);
                    }

                    if (word[i].Contains("GI") || word[i].Contains("GE") || word[i].Contains("GY"))
                    {
                        word[i] = word[i].Replace('G', 'J');
                    }

                    else if (word[i].Contains('G'))
                    {
                        word[i] = word[i].Replace('G', 'K');
                    }

                    if (word[i].Substring(word[i].Length - 2) == "GH")
                    {

                    }

                    else if (word[i].Contains("GH") || word[i].Contains("AH") || word[i].Contains("EH") || word[i].Contains("IH") || word[i].Contains("OH") || word[i].Contains("UH"))
                    {
                        word[i] = word[i].Remove(word[i].IndexOf('H'), 1);
                    }

                    if (word[i].Contains("PH"))
                    {
                        word[i] = word[i].Replace("PH", "F");
                    }

                    if (word[i].Contains("SIA"))
                    {
                        word[i].Replace("S", "X");
                    }

                    if (word[i].Contains("SIO"))
                    {
                        word[i].Replace("S", "X");
                    }

                    if (word[i].Contains("SH"))
                    {
                        word[i].Replace("S", "X");
                    }

                    if (word[i].Contains("TIA"))
                    {
                        word[i].Replace("T", "X");
                    }

                    if (word[i].Contains("TIO"))
                    {
                        word[i].Replace("T", "X");
                    }

                    if (word[i].Contains("TH"))
                    {
                        word[i].Replace("TH", "0");
                    }

                    if (word[i].Contains("TCH"))
                    {
                        word[i].Remove(word[i].IndexOf("T"), 1);
                    }

                    if (word[i].Contains('Q'))
                    {
                        word[i] = word[i].Replace("Q", "K");
                    }

                    if (word[i].Contains('V'))
                    {
                        word[i] = word[i].Replace("V", "F");
                    }

                    if (word[i].Contains("WA") || word[i].Contains("WE") || word[i].Contains("WI") || word[i].Contains("WO") || word[i].Contains("WU"))
                    {

                    }

                    else if (word[i].Contains('W'))
                    {
                        word[i] = word[i].Remove(word[i].IndexOf("W"), 1);
                    }

                    if (word[i].Contains('X'))
                    {
                        word[i] = word[i].Replace("X", "KS");
                    }

                    if (word[i].Contains("YA") || word[i].Contains("YE") || word[i].Contains("YI") || word[i].Contains("YO") || word[i].Contains("YU"))
                    {

                    }

                    else if (word[i].Contains('Y'))
                    {
                        word[i] = word[i].Remove(word[i].IndexOf("Y"), 1);
                    }

                    if (word[i].Contains('Z'))
                    {
                        word[i] = word[i].Replace("Z", "S");
                    }

                    return word;
                }
            }
            return null;
        }

    }
}
