using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal! (press enter to continue)");
        Console.ReadLine();
        int choice = 0;
        Journal journal = new Journal();
        while(choice != 5) {
            Console.WriteLine("What would you like to do? (enter a number)");
            Console.WriteLine("1: Write new Entry.");
            Console.WriteLine("2: View current entries.");
            Console.WriteLine("3. Save current entries.");
            Console.WriteLine("4: Load previous entries from file.");
            Console.WriteLine("5: Quit");

            choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                journal.NewEntry();
            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                //journal.Save();
            }
            else if (choice == 4)
            {
                //journal.Load();
            }
            else if (choice == 5)
            {
                //do nothing
            }
            else
            {
                Console.WriteLine("please enter a number 1 through 5.");
            }
            
            
            
        }
        
    }
}