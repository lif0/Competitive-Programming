using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class RomanNumerals
    {
        public static string ToRoman(int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append("I");
                result.Replace("IIII", "IV");
                result.Replace("VIV", "IX");
                result.Replace("IXI", "X");
                result.Replace("IVI", "V");
                result.Replace("VV", "X");
                result.Replace("XXXX", "XL");
                result.Replace("XLX", "L");
                result.Replace("LXL", "XC");
                result.Replace("XCX", "C");
                result.Replace("LL", "C");
                result.Replace("CCCC", "CD");
                result.Replace("CDC", "D");
                result.Replace("DCD", "CM");
                result.Replace("CMC", "M");
                result.Replace("DD", "M");
            }
            return result.ToString();
        }

        static Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            {'I', 1    },
            {'V', 5    },
            {'X', 10   },
            {'L', 50   },
            {'C', 100  },
            {'D', 500  },
            {'M', 1000 },
        };

        public static int FromRoman(string romanNumeral)
        {
            int result = 0;
            int lastNum = int.MaxValue;
            string subRomanNum = "";
            for (int i = 0; i < romanNumeral.Length; i++)
            {
                char letter = romanNumeral[i];
                int tmpNum = dict[letter];
                if (tmpNum > lastNum)
                {
                    result -= lastNum;
                    result += (tmpNum-lastNum);
                }
                else
                {
                    result += tmpNum;
                }
                lastNum = tmpNum;
            }
            return result;
        }
    }
}
