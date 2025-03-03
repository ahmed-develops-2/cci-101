using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class CheckPermutation
    {
        string String1 = "RATS"; // order asc -> ARST
        string String2 = "ARTS"; // order asc -> ARST

        public bool Checker() {
            if (String1.Length != String2.Length) {
                return false;
            }

            string SortedString1 = new string(String1.OrderBy(letter => letter).ToArray());
            string SortedString2 = new string(String2.OrderBy(letter => letter).ToArray());

            if (SortedString1 == SortedString2) {
                return true;
            }
            return false;
        }
    }
}