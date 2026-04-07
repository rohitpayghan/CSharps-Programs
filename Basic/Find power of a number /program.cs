using System;

class Program
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Pow(num, power));
    }
}
