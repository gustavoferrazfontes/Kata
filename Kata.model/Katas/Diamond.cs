using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.model.Katas
{
    public class Diamond
    {

        private static readonly List<string> Alphabet = new List<string>
        {
            "A", "B", "C", "D","E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "X", "Y", "Z"
        };

        public static List<string> PrintUntil(string letter)
            => GetAlphabetSequenceUntil(GetPositionOf(letter));

        public static string Print(string letter)
        {
            var lettersSelectedToBuildDiamond = PrintUntil(letter);
            var firstPart = BuildUpside(lettersSelectedToBuildDiamond);

            var diamond = BottomSide(lettersSelectedToBuildDiamond, firstPart);
            return diamond.ToString();
        }

        private static StringBuilder BottomSide(List<string> lettersSelectedToBuildDiamond, StringBuilder upside)
        {
            var sb = new StringBuilder(upside.ToString());
            for (int i = 0; i < lettersSelectedToBuildDiamond.Count; i++)
            {
                sb.AppendFormat(
                    "{0}{1}{2}",
                    i == 0 ? string.Empty : "\n",
                    i == 0 || i == lettersSelectedToBuildDiamond.Count
                        ? string.Empty
                        : lettersSelectedToBuildDiamond[lettersSelectedToBuildDiamond.Count - (i + 1)].PadLeft(i + 2),
                    i == 0 || i == lettersSelectedToBuildDiamond.Count - 1
                    ? string.Empty :
                    lettersSelectedToBuildDiamond[lettersSelectedToBuildDiamond.Count - (i + 1)].PadLeft((lettersSelectedToBuildDiamond.Count - (i + 1)) * 2));
            }

            return sb;
        }

        private static StringBuilder BuildUpside(List<string> lettersSelectedToBuildDiamond)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < lettersSelectedToBuildDiamond.Count; i++)
            {
                sb.AppendFormat("\n{0}{1}",
                         lettersSelectedToBuildDiamond[i].PadLeft((lettersSelectedToBuildDiamond.Count + 1) - i),
                    i == 0 || i == lettersSelectedToBuildDiamond.Count
                        ? string.Empty
                        : lettersSelectedToBuildDiamond[i].PadLeft((i * 2)));
            }
            return sb;
        }

        private static List<string> GetAlphabetSequenceUntil(int endpoint) => Alphabet.Take(endpoint).ToList();
        private static int GetPositionOf(string letter) => Alphabet.FindIndex(item => item == letter.ToUpper()) + 1;
    }
}
