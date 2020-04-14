using System;
using System.Collections.Generic;

namespace Kata1
{
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            var counter = new Dictionary<char, int>();
            var chars = word.ToLower().ToCharArray();
            foreach (var c in chars)
            {
                counter.TryGetValue(c, out var v);
                counter[c] = v + 1;
            }
            var res = "";
            foreach (var c in chars)
            {
                res += counter[c] > 1 ? ")" : "(";
            }

            return res;
        }
    }
}
