using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Principal: ");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double r = double.Parse(Console.ReadLine());

        Console.Write("Enter Time: ");
        double t = double.Parse(Console.ReadLine());

        double amount = p * Math.Pow((1 + r / 100), t);
        double ci = amount - p;

        Console.WriteLine("Compound Interest = " + ci);
    }
}
