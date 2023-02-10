using System;

class Program
{
    static void Main()
    {
        double p = double.Parse(Console.ReadLine()), a = p / 3;
        double s = Math.Sqrt(p / 2 * Math.Pow((p / 2 - a), 3));
        Console.WriteLine("Сторона  Площадь");
        Console.WriteLine("{0:f2}     {1:f2}", a, s);
    }
}