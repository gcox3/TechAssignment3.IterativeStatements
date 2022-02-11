// Programmer: Gabrielle Cox
// Assignment: T-3 - Using Iterative Statements
// Date: 02/10/2022
using System;

namespace TechAssignment3.IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input the increment value for CAD 
            Console.Write("CAD Increment Value (5-25): ");
            // Use try catch logic to confirm valid input 
            try
            {
                // Establish variables
                string input = Console.ReadLine();
                int inputval = int.Parse(input);
                double c = 0.792367;
                // Check input is in range
                if (inputval < 5 || inputval > 25)
                {
                    Console.WriteLine("Increment value must be between 5 and 25");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
                // Process valid increment value input
                else if ((inputval >= 5) && (inputval <= 25))
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("CAD" + "\t" + "\t" + "US");
                    Console.WriteLine(" ");
                    for (int i = 0; i <= 200; i += inputval)
                    {
                        // Display incremented CAD values and calculate the conversion to US$
                        Console.WriteLine(i + "\t" + "\t" + String.Format("{0:C}", i * c));
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please run again and enter a value between 5 and 25");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
        }
    }
}
