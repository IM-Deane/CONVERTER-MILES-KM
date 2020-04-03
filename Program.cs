using System;

namespace Converter_Miles_KM
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Program: Distance conversion program.
             * Program asking users for the unit type and distance value they wish to convert and then
             * outputs the new value in either miles or kilometers. Output depends on the initial unit
             * type.
             */

            // Variables
            string userInput; // collects users input
            double answer; // store converted value
            bool running = true; // controls the loop

            Console.WriteLine("DISTANCE CONVERTER:");

            // RUNNING LOOP
            while (running == true)
            {
                // Ask user to specify desired unit type
                Console.Write("\nEnter current unit type ('mi', 'km'): ");
                userInput = Console.ReadLine();
                // CONVERT FROM MILES TO KM
                if (userInput == "mi")
                {
                    Console.WriteLine("Got it. Converting miles to km...");
                    Console.Write("Enter distance (ex: '100'): ");
                    // Convert value to KM
                    userInput = Console.ReadLine();
                    // For now assume input valid
                    answer = Convert.ToDouble(userInput) * 1.60934;
                    // Display answer to console rounded to 2 decimal places
                    Console.WriteLine(userInput + " miles == " + Math.Round(answer, 2) + " km");
                    // Break loop and end program
                    running = false;
                }
                // CONVERT FROM KM TO MILES
                else if (userInput == "km")
                {
                    Console.WriteLine("Got it. Converting km to miles...");
                    Console.Write("Enter distance (ex: '100'): ");
                    // Convert value to MILES
                    userInput = Console.ReadLine();
                    answer = Convert.ToDouble(userInput) / 1.60934;
                    // Display answer to console rounded to 2 decimal places
                    Console.WriteLine(userInput + " km == " + Math.Round(answer, 2) + " miles");
                    // Break loop and end program
                    running = false;

                }
                // INVALID INPUT ENTERED
                else
                {
                    Console.WriteLine("ERROR -- INVALID INPUT ENTERED!! -- TRY AGAIN");

                }
            }
        }
    }
}
