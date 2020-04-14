using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata1
{
    public class RomanDecode
    {
        public static int Solution(string roman)
        {
            var mappings = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000,
            };

            var inverseRoman = roman.ToUpper().Reverse().ToArray();
            var total = 0;
            var currentValue = 0;
            var lastValue = 0;

            foreach (var iRC in inverseRoman)
            {
                lastValue = currentValue;
                currentValue = mappings[iRC];
                if (lastValue > currentValue)
                {
                    total -= currentValue;
                }
                else
                {
                    total += currentValue;
                }
            }
            return total;
        }
    }
}
