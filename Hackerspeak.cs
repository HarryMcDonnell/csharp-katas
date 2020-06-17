using System;

namespace katas
{
    class HackerCode
    {
        public string HackerSpeak(string input) 
        {
            string Hacker = "";
            for (int i = 0; i < input.Length; i++)
            {
                char char1 = input[i];
                switch (char1)
                {
                    case 'a':
                        Hacker += '4';
                        break;
                    case 'e':
                        Hacker += '3';
                        break;
                    case 'i':
                        Hacker += '!';
                        break;
                    case 'o':
                        Hacker += '0';
                        break;
                    case 's': 
                        Hacker += '5';
                        break;
                    default:
                        Hacker += char1;
                        break;
                }
            }
            return Hacker;
        }
    }
}