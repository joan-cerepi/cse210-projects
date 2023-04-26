using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = 0;
        int numbersTotal = 0;
        double numbersAverage = 0.0;
        int maxNumber = 0;
        Console.WriteLine("Enter a list of number, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        foreach (int number in numbers)
        {
            // Add each number to the numbersTotal variable
            // to get the total.
            numbersTotal += number;

            // Check each number if it's greater than the current number in the 
            // maxNumber variable, if it is assign it to the maxNumber variable.
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        // Assign the mean average to the numbersAverage variable.
        // Make numbersTotal a floating point value first.
        numbersAverage = ((double)numbersTotal) / numbers.Count;

        Console.WriteLine($"The sum is: {numbersTotal}");
        Console.WriteLine($"The average is: {numbersAverage}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}