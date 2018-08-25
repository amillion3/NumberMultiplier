using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            // user selects option 1 or option 2
            Console.WriteLine("Please choose an option below:");
            Console.WriteLine("1. Input a comma-separated string of numbers to MULTIPLY together.");
            Console.WriteLine("2. Input a comma-separated string of numbers to SQUARE individually.");
            string userSelection = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Thank you for your selection.");
            Console.WriteLine("");

            Console.WriteLine("Please input a comma-separated string of numbers,");
            Console.WriteLine("such as '1, 2, 3, 4, 5' :");
            string inputString = Console.ReadLine();

            if (userSelection == "1") // Multiply option
            {
                int multiplyTotal = 1;
                string [] inputArray = inputString.Split(','); // split into a string array by commas
                foreach (string a in inputArray) // loop through each string 
                {
                    multiplyTotal = int.Parse(a) * multiplyTotal; // convert to int and multiply together
                }
                Console.WriteLine("The final total is " + multiplyTotal);
                Console.ReadLine();
            }
            else if (userSelection == "2") // Square option
            {
                int temp;
                string tempOutput = ""; // temporary output of string during processing
                string[] inputArray = inputString.Split(','); // split into a string array by commas
                foreach (string b in inputArray) // loop through each string 
                {
                    temp = int.Parse(b) * int.Parse(b); // squaring operation
                    tempOutput += (temp + ",");
                }
                string squaredOutput = tempOutput.TrimEnd(','); // trim trailing comma
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
