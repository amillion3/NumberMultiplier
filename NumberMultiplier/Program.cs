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
            if (userSelection == "1")
            {
                Console.WriteLine("Please input a comma-separated string of numbers,");
                Console.WriteLine("such as '1, 2, 3, 4, 5' :");
                string inputString = Console.ReadLine();

                int total = 1;
                string [] inputArray = inputString.Split(',');
                foreach (string a in inputArray)
                {
                    total = int.Parse(a) * total;
                }
                Console.WriteLine("The final total is " + total);
                Console.ReadLine();

            }
            else if (userSelection == "2")
            {

            }
            else
            {
                Console.WriteLine("You failed.");
            }


        }
    }
}
