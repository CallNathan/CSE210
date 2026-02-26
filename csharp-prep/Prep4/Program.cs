using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber;
        string newString = "";
        int total = 0;
        float Average;
        int largestNumber = int.MinValue;
        int smallestPositiveNumber = int.MaxValue;
        Console.WriteLine("Enter a list of numbers, type stop when finished.");
        while(newString != "stop")
        {
            Console.Write("Enter Number: ");
            newString = Console.ReadLine();
            if (int.TryParse(newString, out newNumber)) {
                numbers.Add(newNumber);
            }
            else if (newString == "stop"){
                Console.WriteLine("Calculating");
            }
            else
            {
                Console.WriteLine("that wasn't a valid number. Please try again");
            }
        }
        Console.WriteLine($"you entered {numbers.Count} numbers"); 
        Console.WriteLine("The numbers are:");
        numbers.Sort();
        foreach (int value in numbers)
        {
            Console.Write($"{value}, ");
            total = total + value;
            if (value > largestNumber)
            {
                largestNumber = value;
            }
            if (value >= 0 && value < smallestPositiveNumber)
            {
                smallestPositiveNumber = value;
            }
        }
        Console.WriteLine();
        Average = (float)total/numbers.Count;
        Console.WriteLine($"The sum of all numbers is: {total}");
        Console.WriteLine($"The Average is {Average}");
        Console.WriteLine($"The Largest number is {largestNumber}");
        if(smallestPositiveNumber == int.MaxValue)
        {
            //DO NOTHING
        }
        else
        {
            Console.WriteLine($"The smallest positive integer is {smallestPositiveNumber}");
        }
    }
}