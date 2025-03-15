using System;
using System.Text;
class Program
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        Console.WriteLine(((num * (num-1) * (num-2)/6)));
        Console.WriteLine(3);
    }
}