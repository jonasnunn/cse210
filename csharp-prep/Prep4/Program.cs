using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int input = -1;

        // Build list
        while (input != 0)
        { 
        Console.Write("Please enter a number (0 to end): ");
        string inputStr = Console.ReadLine();
        input = int.Parse(inputStr);
        if (input != 0)
        {
            numbers.Add(input);
        }
        }

        int sum = 0;
        int max = 0;
        // Iterate through list
        foreach(var number in numbers)
        {
            sum += number;
            // Console.WriteLine(number);
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The avg. is {sum / numbers.Count}");
        Console.WriteLine($"The largest number is {max}");

    }
}