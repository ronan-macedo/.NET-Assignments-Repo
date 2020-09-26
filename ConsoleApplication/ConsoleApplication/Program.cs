using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables to be displayed
            string name = "Ronan";
            string country = "Brazil";

            Console.WriteLine($"\nMy name is {name}, I am from {country}.");

            // Display current date
            /**
             * Using CultureInfo to override the system date/time local configuration 
             */
            string currentDateValue = DateTime.Now.ToString("d", CultureInfo.CreateSpecificCulture("en-US"));
            Console.WriteLine($"\nThe current date is {currentDateValue}.");

            // Days until Christmans
            string chirstmasDateValue = "12/25/2020";
            DateTime currentDate = DateTime.Parse(currentDateValue, CultureInfo.CreateSpecificCulture("en-US"));
            DateTime chirstmasDate = DateTime.Parse(chirstmasDateValue, CultureInfo.CreateSpecificCulture("en-US"));
            TimeSpan daysUntilChristmas = chirstmasDate.Subtract(currentDate);

            Console.WriteLine($"\nDays until Christmas: {daysUntilChristmas.TotalDays} days");

            // Window size calculator
            void windowCalculator()
            {
                double width, height, woodLength, glassArea;
                string widthString, heightString;

                Console.WriteLine("\n\t** Window glazing calculator **");

                Console.Write("\nPlease, enter the the glass width(in meters): ");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);

                Console.Write("\nPlease, enter the the glass height(in meters): ");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);

                woodLength = 2 * (width + height) * 3.25;

                glassArea = 2 * (width * height);

                Console.WriteLine($"\n\tThe length of the wood is {woodLength} feet.");
                Console.WriteLine($"\n\tThe area of the glass is {glassArea} square meters.");

            }
            windowCalculator();

            Console.ReadKey();

        }
    }
}
