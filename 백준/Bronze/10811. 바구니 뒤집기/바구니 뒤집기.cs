using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        int basket = int.Parse(s[0]);
        int[] b = new int[basket];
        for(int i=0;i<basket;i++)
        {
            b[i] = i + 1;
        }
        for(int i = 0; i < int.Parse(s[1]); i++)
        {
            string[] ss = Console.ReadLine().Split(' ');
            int first = int.Parse(ss[0]) - 1;
            int second = int.Parse(ss[1]) - 1;
            Array.Reverse(b, first, second - first+1);
        }

        for(int i = 0; i<basket; i++)
        {
            Console.Write(b[i] + " ");
        }

    }
}