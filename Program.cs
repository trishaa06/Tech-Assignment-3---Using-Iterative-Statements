// Name: Trisha No last name //

// Header File: ConvertCurrency.cs //
// Description: C# Program Console Program for converting currency from CAD to US$ //

using System;

public class ConvertCurrency
{
    public static void Main(string[] args)
    {
        try
        {
            // Print a message (on screen) to require user enter a CAD value //
            Console.Write("Please enter a CAD increment value: ");

            // Define data type for CAD value //
            float CAD = float.Parse(Console.ReadLine());
            if (CAD >= 5F && CAD <= 25F)
            {
                float unit = 0.792367F; // The currency unit to convert from CAD to US$ - 1CAD = 0.792367US$ //
                Console.Write("CAD  ");
                Console.WriteLine(CAD);
                Console.Write("CAD  ");
                Console.WriteLine("US$");
                float i = 0F;
                // Loop to calculate and print a value table includes: CAD value and corresponding US$ value //
                while (i * CAD <= 200F)
                {
                    float CAD_value = i * CAD;
                    float US_value = CAD_value * unit;
                    Console.Write(CAD_value);
                    Console.Write("    ");
                    Console.WriteLine(US_value);
                    i++;
                }
            }
        }
        catch (Exception error)
        {
            // Handle wrong cases (input is not numeric OR input value greater than 25 or less than 5) //
            Console.Write(error.Message);
            Console.ReadKey();
        }
    }
}

