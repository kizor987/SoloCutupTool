using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoloCutupTool.Handlers
{
    public static class RandomHandler
    {
        private static Random random;

        private static void Init()
        {
            if (random == null) random = new Random();
        }

        public static int GetRandom(int min, int max)
        {
            Init();
            return random.Next(min, max);
        }
        public static IEnumerable<T> RandomizeList<T>(IEnumerable<T> source)
        {
            Random rnd = new Random();
            return source.OrderBy<T, int>((item) => rnd.Next());
        }

        public static List<string> GetListFromItems(ListBox theBox)
        {
            var result = new List<string>();
            foreach (var item in theBox.Items)
            {
                result.Add(item.ToString());
            }
            return result;
        }
    }
}
