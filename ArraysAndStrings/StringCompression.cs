
using System.Text;
using System;

namespace ArraysAndStrings {
    public class StringCompression {
        public void Compress(string InputString = "aabccccd") {
            long memoryBefore = GC.GetTotalMemory(true);
            
            int LetterCount = 1;
            StringBuilder CompressedString = new StringBuilder("");

            for (int i = 1; i < InputString.Length; i++) {
                if (InputString[i] == InputString[i-1]) {
                    LetterCount++;
                } else {
                    CompressedString.Append($"{InputString[i - 1].ToString() + LetterCount.ToString()}");
                    LetterCount = 1;
                }
            }

            // Loop exits at last character without appending last character.
            // Need to append it out of loop (ONLY THE LAST ONE).

            CompressedString.Append($"{InputString[^1].ToString() + LetterCount.ToString()}");

            long memoryAfter = GC.GetTotalMemory(true);

            Console.WriteLine(CompressedString);
            Console.WriteLine($"Memory Used: {memoryAfter - memoryBefore} bytes");
        }
    }
}