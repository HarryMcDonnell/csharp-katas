using System;

namespace katas
{
    class Program
    {
        static void Main(string[] args)
        {
            PalinCode soManyVari = new PalinCode();
            HackerCode translateToHacker = new HackerCode();
            Primecode testPrime = new Primecode();
            NumFormat phoneNum = new NumFormat();
            Pikata PiFunc = new Pikata();
            shhh NoYell = new shhh();
            StringSpace IsthereaSpace = new StringSpace();
            // string input = Console.ReadLine();
            testPrime.isPrime(244);
            phoneNum.formatNum(9876543215);
            // Console.WriteLine("Palindrome to test:");
            // soManyVari.IsPali(input);
            // Console.WriteLine("Enter sentence to translate:");
            // string text = Console.ReadLine();
            // Console.WriteLine(translateToHacker.HackerSpeak(text));
            PiFunc.PiToPlace(5);
            Console.WriteLine(IsthereaSpace.HasSpaces("t e s t"));
            Console.WriteLine(NoYell.NoYelling("Test."));
        }
    }
}
