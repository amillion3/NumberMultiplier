using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a comma-separated string of numbers:");
            string inputString = Console.ReadLine();

            int total = 1;
            string [] inputArray = inputString.Split(',');
            foreach (string a in inputArray)
            {
                total = int.Parse(a) * total;
            }
        }
    }
}
