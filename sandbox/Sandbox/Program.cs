using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        int x = 20;
        Console.WriteLine($"In main: {x}");
        passByValue(x);
        Console.WriteLine($"in main: {x}");
        passByRef(ref x);
        Console.WriteLine($"in main: {x}");

        int z;
        passByOut(out z);
        Console.WriteLine(z);

    }

    public static void passByRef(ref int x)
    {
        x++;
        Console.WriteLine($"in value function: {x}");
    }
    public static void passByValue(int x)
    {
        x++;
        Console.WriteLine($"In value: {x}");
    }
    public static void passByOut(out int y)
    {
        y = 10;
    }
}

