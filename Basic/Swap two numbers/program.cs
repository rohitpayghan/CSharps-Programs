using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After Swap:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
