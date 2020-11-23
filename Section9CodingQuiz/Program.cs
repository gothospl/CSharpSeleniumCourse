using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9CodingQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valuesCount = new int[11];
            int numbersOutsideRange = 0;
            int nonNumericItems = 0;

            PrimeArray(valuesCount);
            nonNumericItems = GetValues(valuesCount, ref numbersOutsideRange);
            DisplayResults(valuesCount, nonNumericItems, numbersOutsideRange);
            Console.ReadKey();
        }


        public static void PrimeArray(int[] valuesCount)
        {
            for (int i=0; i<11; i++)
            {
                valuesCount[i] = 0;
            }
        }

        public static int GetValues(int[] valuesCount, ref int numbersOutsideRange)
        {
            int inValue;
            string stringInput;
            bool moreInput = true;
            int nonNumericItems = 0;

            Console.Clear();
            while(moreInput)
            {
                Console.Write($"\nInput a number between 0 and 10 (-1 to stop): ");
                stringInput = Console.ReadLine();

                while (int.TryParse(stringInput, out inValue) == false)
                {
                    Console.Write($"\nInvalid data type - value must be numeric between 0 and 10 (-1 to stop): ");
                    stringInput = Console.ReadLine();
                    nonNumericItems++;
                }

                if (inValue == -1)
                    moreInput = false;
                else if (inValue < -1 || inValue > 10)
                {
                    Console.Write($"Invalid number - must be between 0 and 10 -  (-1 to stop): ");
                    numbersOutsideRange++;
                }
                else
                {
                    valuesCount[inValue]++;
                }
            }
            return nonNumericItems;

        }

        public static void DisplayResults(int[] valuesCount, int nonNumericItems, int numberOutsideRange)
        {
            int validCount = 0;
            Console.Clear();
            Console.WriteLine($"\tInput Data App\n");
            Console.WriteLine($"InputValue\tCount");

            for (int x = 0; x < 11; x++)
            {
                if (valuesCount[x] != 0)
                {
                    validCount += valuesCount[x];
                    Console.WriteLine($"{x}\t{valuesCount[x]}");
                }
            }
            Console.WriteLine($"\nNumber of Valid Entries: {validCount}");
            Console.WriteLine($"\nNumber of Values Outside Accepted Range: {numberOutsideRange}");
            Console.WriteLine($"\nNumber of Non-numeric Values: {nonNumericItems}");
            Console.WriteLine($"\nTotal Number of Inputs: {validCount + nonNumericItems + numberOutsideRange}");
        }
    }
}
