using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int largestNumber = 0;
        int intNumbers;
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do {
            Console.Write("Enter number");
            string newNumber = Console.ReadLine();
            intNumbers = int.Parse(newNumber);
            if (intNumbers != 0){ //to exclude 0 from the final list
                numbers.Add(intNumbers);
            
                foreach (int number in numbers) {
                    sum = sum + number;
                    if (number > largestNumber) {
                        largestNumber = number;
                    }

                }
            }   
        } while (intNumbers != 0);
        
        int average = (sum/(numbers.Count));
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        foreach (int number in numbers){
            Console.WriteLine(number);
        }
        
    }
}