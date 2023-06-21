using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_2_AdamAsmaca
{
    /// <summary>
    /// Picks an item from an array randomly.
    /// </summary>
    public static class PickRandom
    {
        /// <summary>
        /// Picks an item from an array randomly.
        /// </summary>
        /// <param name="items">The items to select from.</param>
        public static T ChooseRandomItem<T>(this IEnumerable<T> items)
        {
            Random prng = new Random(DateTime.UtcNow.Ticks.GetHashCode());
            return items.ElementAt(prng.Next(0, items.Count()));
        }
    }
    /// <summary>
    /// Methods for replacing chars in strings.
    /// </summary>
    public static class Replacer
    {
        public static string ReplaceIndex(this string str, int index, char newCh)
        {
            StringBuilder newStr = new StringBuilder(str);
            newStr[index] = newCh;

            return newStr.ToString();
        }
        public static string ReplaceChars(this string str, Dictionary<int, char> replacements)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (replacements.ContainsKey(i))
                    result += replacements[i];
                else
                    result += str[i];
            }

            return result;
        }

        public static Dictionary<char, int> FindIndicesOf(this string str, IEnumerable<char> chs)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var item in chs)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == item)
                        result.Add(item, i);
                }
            }

            return result;
        }
    }
}
