using System;
using System.Text;
class Program
{
    static void Main()
    {
        int[] x = new int[3];
        int[] y = new int[3];
        for (int i = 0; i<x.Length;i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            x[i] = int.Parse(input[0]);
            y[i] = int.Parse(input[1]);
        }
        int ansX = x[0];
        int ansY = y[0];

        ansX = ansX == x[1] ? x[2] : ansX == x[2] ? x[1] : ansX;
        ansY = ansY == y[1] ? y[2] : ansY == y[2] ? y[1] : ansY;
        Console.WriteLine(ansX + " " + ansY);
    }

}