using System;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        int times = int.Parse(Console.ReadLine());

        for (int i = 0; i < times; i++)
        {
            string[] s = Console.ReadLine().Split();
            for(int j = 0; j < s[1].Length; j++)
            {
                for (int k= 0; k< int.Parse(s[0]); k++)
                    Console.Write(s[1][j]);
            }
            Console.WriteLine();
        }
        

    }
}