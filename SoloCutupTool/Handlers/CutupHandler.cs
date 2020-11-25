using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoloCutupTool.Handlers
{
    public static class CutupHandler
    {
        public static List<string> GetRandomCutups (List<string> listCutups, int number)
        {
            var newCutups = new List<string>();
            for (int x = 0; x < number; x++)
            {
                var toAdd = listCutups[RandomHandler.GetRandom(0, listCutups.Count + 1)];
                newCutups.Add(toAdd);
            }
            return newCutups;
        }
        public static List<string> LoadCutupsFromText(string[] intakeList)
        {
            var results = new List<string>();
            int x = 0;
            string tempCutup = "";

            foreach (String word in intakeList)
            {
                if (word.Length > 0)
                {
                    if (x < 5)
                    {
                        tempCutup += word;
                        if (x < 4)
                        {
                            tempCutup += " ";
                        }
                        x++;
                    }
                    else
                    {
                        tempCutup = Regex.Replace(tempCutup, @"\t|\n|\r", "");
                        if (tempCutup.Contains("."))
                        {
                            tempCutup = CleanPeriods(tempCutup);
                        }
                        results.Add(tempCutup);

                        tempCutup = word + " ";
                        x = 1;
                    }
                }
            }

            return results;
        }

        private static string CleanPeriods(string toClean)
        {
            var result = toClean;
            int index = result.IndexOf('.');
            if (index + 1 < result.Length)
            {
                char checkChar = result[index + 1];
                if (!checkChar.Equals(' '))
                {
                    result = result.Insert(index+1, " ");
                }
            }

            return result;
        }
    }
}
