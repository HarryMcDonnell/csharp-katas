using System;
namespace katas
{
    class shhh
    {
        //check from the back of thr string
        //if ! is next to another ! then remove "first" ! (working backwards)
        //continue until ! is next to char
        public string NoYelling(string input)
        {
            string fixedString = input;
            Console.WriteLine(input.Length);
            int i = input.Length-1;
            while (input[i] == '!' || input[i] == '?')  //starting from the back, while char is '!' or '?'
            {
                if (input[i-1] == '!')                  //if the next char is also '!',
                {
                    fixedString = input.Substring(0,i);     //then cut off final char
                }
                if (input[i-1] == '?')
                {
                    fixedString = input.Substring(0,i);
                }
                i--;                                    //decrement to move to next char from the back.
            }            
            return fixedString;
        }
    }
}