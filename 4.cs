using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter the first integer");
            string temp = Console.ReadLine();
            int i = Int32.Parse(temp);
            Console.WriteLine("Please enter the second integer");
            temp = Console.ReadLine();
            int j = Int32.Parse(temp);
            int k = i / j;
            Console.WriteLine(k);
        }
        catch (Exception e)
        {
            Console.WriteLine("An exception was thrown: {0}",e.Message);
        }
    }
}