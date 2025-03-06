
using System.Text;

namespace ArraysAndStrings {
    public class Urlify {        
        public string MakeUrl(string InputString, int StringLength) {
            if (StringLength != InputString.Length) {
                return "Length input by user is not true";
            }

            StringBuilder SB = new StringBuilder(InputString, StringLength);
            return SB.Replace(" ", "%20").ToString();
        }

    }
}