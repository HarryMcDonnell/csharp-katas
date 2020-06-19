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
            // string input = Console.ReadLine();
            testPrime.isPrime(244);
            phoneNum.formatNum(9876543215);
            // Console.WriteLine("Palindrome to test:");
            // soManyVari.IsPali(input);
            // Console.WriteLine("Enter sentence to translate:");
            // string text = Console.ReadLine();
            // Console.WriteLine(translateToHacker.HackerSpeak(text));

        }
    }
}
