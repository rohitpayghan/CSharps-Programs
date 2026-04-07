using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        for (int i = 1; i <= 5; i++)
            Console.WriteLine(rand.Next(1, 100));
    }
}
