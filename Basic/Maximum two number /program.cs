using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
            Console.WriteLine("Maximum = " + a);
        else
            Console.WriteLine("Maximum = " + b);
    }
}
