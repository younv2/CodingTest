using System;
using System.Text;
class Program
{
    //1 = 4
    //n = 2(n-1) + 2n + 2 
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine(2*(n-1) + 2 * n + 2);
    }

}