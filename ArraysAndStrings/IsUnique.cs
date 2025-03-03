using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class IsUnique
    {
        public bool CheckIfUnique(string SampleString) {
            // S T R I N G -> return true;
            // L O V E L Y -> return false;

            if (SampleString.Length > 128) {
                Console.WriteLine("String exceeded length of 128");
            }
            
            bool[] SampleSet = new bool[128];

            for (int i = 0; i < SampleString.Length; i++) {
                int TempAscii = SampleString[i];
                if (SampleSet[TempAscii]) {
                    return false;
                }
                SampleSet[TempAscii] = true;
            }
            
            return true;
        }

        public bool CheckIfUniqueBitwise(string SampleString) {
            if (SampleString.Length > 128) {
                Console.WriteLine("String exceeded length of 128");
            }

            int Checker = 0;
            for (int i = 0; i < SampleString.Length; i++) {
                int Temp = SampleString[i] - 'a';
                // 1 << 0 -> A 0000000001
                // 1 << 1 -> B 0000000011
                // 1 << 2 -> C 0000000111
                // 1 << 8 -> I 0010000111

                // ABCB 
                // -> checker (0000000111)
                // -> B (0000000010)
                // checker & B ->
                //      0000000111
                //      0000000010 
                //      0000000010 -> Non-zero output, thus repitition occured
                if ((Checker & (1 << Temp)) > 0) {
                    return false;
                }
                // 0000000000 -> 0000000001 A (0000000001)
                // 0000000001 -> 0000000011 B (0000000010)
                // 0000000111 -> 0000000111 C (0000000100)
                Checker |= (1 << Temp);
            }

            return true;
        }
    }
}