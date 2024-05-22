using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "testing.txt";
        string content = "Hello";

        try
        {
            // Get the absolute path of the file
            string filePath = Path.GetFullPath(fileName);
            Console.WriteLine($"Writing to file: {filePath}");

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(content);
                outputFile.Flush(); // Explicitly flush the stream
            }
            Console.WriteLine("Content written successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}