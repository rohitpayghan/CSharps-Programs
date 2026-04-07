using System;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;

        Console.WriteLine("Area = " + area);
    }
}
