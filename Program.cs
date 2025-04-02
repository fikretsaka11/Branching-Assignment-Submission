using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Begins by showing a welcome message to introduce the shipping service
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompts for and receives the weight information of the package
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            // Assesses if the package weight is beyond the maximum allowed
            if (weight > 50)
            {
                // Provides feedback that the package cannot be processed due to weight
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Stops further processing for overweight packages
            }

            // Gathers the width measurement for the package
            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());

            // Gathers the height measurement for the package
            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());

            // Gathers the length measurement for the package
            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());

            // Determines if the total dimensions exceed the shipping threshold
            if (width + height + length > 50)
            {
                // Informs that the package dimensions are not acceptable
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program for packages with excessive dimensions
            }

            // Calculates the shipping cost according to the specified formula
            float quote = (height * width * length * weight) / 100;

            // Displays the final shipping cost with proper currency formatting
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Keeps the console window visible until user input
            Console.ReadKey();
        }
    }
}