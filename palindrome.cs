using System;
namespace katas
{
    class PalinCode
    {
        public bool IsPali(string input) 
        {
            string yarra = "";
            string lower = input.ToLower();
            for (int i = input.Length-1; i >-1; i--)
            {
                yarra += lower[i]; 
            }
            Console.WriteLine(yarra);
            if (input == yarra)
            {
                Console.WriteLine($"{input} is a palindrome.");
                return true;
            }
            else{
                Console.WriteLine($"{input} is not a palindrome.");
                return false;
            }
            
        }
    }
}