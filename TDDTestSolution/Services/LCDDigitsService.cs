using System.Collections.Generic;
using System.Text;
using TDDTestSolution.Interfaces;

namespace TDDTestSolution.Services
{
    public class LCDDigitsService : ILCDDigitsService
    {
        private const int DIGITS_SIZE = 3; 
        private readonly Dictionary<uint, string[]> _numberDictionary = new Dictionary<uint, string[]>
        {
            {
                0, new string[] 
                {
                    "._.",
                    "|.|",
                    "|_|"
                }
            },
            {
                1, new string[]
                {
                    "...",
                    "..|",
                    "..|"
                }
            },
            {
                2, new string[]
                {
                    "._.",
                    "._|",
                    "|_."
                }
            },
            {
                3, new string[]
                {
                    "._.",
                    "._|",
                    "._|"
                }
            },
            {
                4, new string[]
                {
                    "...",
                    "|_|",
                    "..|"
                }
            },
            {
                5, new string[]
                {
                    "._.",
                    "|_.",
                    "._|"
                }
            },
            {
                6, new string[]
                {
                    "._.",
                    "|_.",
                    "|_|"
                }
            },
            {
                7, new string[]
                {
                    "._.",
                    "..|",
                    "..|"
                }
            },
            {
                8, new string[]
                {
                    "._.",
                    "|_|",
                    "|_|"
                }
            },
            {
                9, new string[]
                {
                    "._.",
                    "|_|",
                    "..|"
                }
            }
        };

        /// <summary>
        /// Convert number to LCD digits
        /// </summary>
        /// <param name="value">Number</param>
        /// <returns>String with LCD digits</returns>
        public string Convert(uint value)
        {
            var digits = GetIntArray(value);
            var result = new StringBuilder();

            for (int i = 0; i < DIGITS_SIZE; i++)
            {
                foreach (var digit in digits)
                {
                    result.Append($"{_numberDictionary[digit][i]} ");
                }
                result.Append("\r\n");
            }

            return result.ToString();
        }

        /// <summary>
        /// Split complex number to separate digits
        /// </summary>
        /// <param name="num">Complex number</param>
        /// <returns>Array of simple digits</returns>
        private uint[] GetIntArray(uint num)
        {
            var listOfInts = new List<uint>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}
