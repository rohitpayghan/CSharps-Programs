using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        long fact = 1;

        for (int i = 1; i <= num; i++)
            fact *= i;

        Console.WriteLine("Factorial = " + fact);
    }
}
