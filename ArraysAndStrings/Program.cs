
using System;
using System.Text;
using ArraysAndStrings;

class Program {
    public static void Main(string[] args) {
        // _________________________ IsUnique.cs _____________________________
        // IsUnique Checker = new IsUnique();
        // bool Result = Checker.CheckIfUniqueBitwise("ARIFA");
        // Console.WriteLine(Result);

        // _____________________ CheckPermutation.cs _________________________
        CheckPermutation Checker = new CheckPermutation();
        bool Result = Checker.Checker();
        Console.WriteLine(Result);
    }
}