using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose an option below:");
            Console.WriteLine("1. Comma-separated string of numbers to MULTIPLY together.");
            Console.WriteLine("2. Comma-separated string of numbers to SQUARE individually.");
            string userSelection = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Thank you for your selection.");
            Console.WriteLine("");

            Console.WriteLine("Please input a comma-separated string of numbers,");
            Console.WriteLine("such as '1, 2, 3, 4, 5' :");
            string inputString = Console.ReadLine();

            if (userSelection == "1") // Multiply
            {
                int multiplyTotal = 1;
                string [] inputArray = inputString.Split(',');
                foreach (string a in inputArray)
                {
                    multiplyTotal = int.Parse(a) * multiplyTotal;
                }
                Console.WriteLine("The final total is " + multiplyTotal);
                Console.ReadLine();
            }
            else if (userSelection == "2") // Square
            {
                int temp;
                string tempOutput = "";
                string[] inputArray = inputString.Split(',');
                foreach (string b in inputArray)
                {
                    temp = int.Parse(b) * int.Parse(b); // squaring operation
                    tempOutput += (temp + ",");
                }
                string squaredOutput = tempOutput.TrimEnd(',');
                Console.WriteLine("The final output is " + squaredOutput);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You failed.");
            }


        }
    }
}
