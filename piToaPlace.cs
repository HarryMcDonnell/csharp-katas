using System;
namespace katas
{
    class Pikata
    {
        public void PiToPlace(int input)
        {
            string piString = Convert.ToString(Math.PI);
            string piToPlace = piString.Substring(0, input+3);
            decimal output = Decimal.Round(Convert.ToDecimal(piToPlace), input);
            Console.WriteLine(output);
        }
    }
}