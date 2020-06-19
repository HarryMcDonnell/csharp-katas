using System;
namespace katas
{
    class Primecode
    {
        public bool isPrime(int input)
        {
            bool test = true;
            for (int i = 2; i <= input/2; i++) 
            {
                if (input % i == 0) 
                {
                    test = false;
                }
            }
            if (test)
            {
                Console.WriteLine("The number is prime");
            }
            else{
                Console.WriteLine("The number is not prime.");
            }
            return test;
        }
    }
}