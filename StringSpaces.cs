using System;
namespace katas
{
    class StringSpace
    {
        public bool HasSpaces(string input)
        {
            bool space = false;
            for (int i = 0; i <= input.Length-1; i++)
            {
                if (input[i] == ' ')
                {
                    space = true;
                }
            }
        return space;
        }

    }
}