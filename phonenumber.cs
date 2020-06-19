using System;
namespace katas
{
    class NumFormat
    {
        public void formatNum(long rawNum)
        {
            string number = Convert.ToString(rawNum);
            switch (number.Length)
            {
                case(10):
                    string US1 = "";
                    string US2 = "";
                    string US3 = "";
                    for (int i = 0; i < 3; i++) 
                    {
                    US1 += number[i];
                    }
                    for (int i = 3; i < 6; i++) 
                    {
                    US2 += number[i];
                    }
                    for (int i = 6; i < 10; i++) 
                    {
                    US3 += number[i];
                    }
                    Console.WriteLine("US Format: ("+US1+") " + US2 + "-" + US3);
                    break;
                case (11) :
                    string UK1 = "";
                    string UK2 = "";
                    string UK3 = "";
                    for (int i = 0; i < 5; i++) {
                    UK1 += number[i];
                    }
                    for (int i = 5; i < 8; i++) {
                    UK2 += number[i];
                    }
                    for (int i = 8; i < 11; i++) {
                    UK3 += number[i];
                    }
                    Console.WriteLine("UK Format: " + UK1 + " " + UK2 + " " + UK3);
                    break;
                default:
                    Console.WriteLine("Please enter a 10 or 11 digit number.");
                    break;
            }
        }
    }
}