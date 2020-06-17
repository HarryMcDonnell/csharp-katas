using System;

namespace katas
{
    class Program
    {
        static void Main(string[] args)
        {
            PalinCode soManyVari = new PalinCode();
            HackerCode translateToHacker = new HackerCode();
            // Console.WriteLine("Palindrome to test:");
            // string input = Console.ReadLine();
            // soManyVari.IsPali(input);
            Console.WriteLine("Enter sentence to translate:");
            string text = Console.ReadLine();
            Console.WriteLine(translateToHacker.HackerSpeak(text));

        }
    }
}
