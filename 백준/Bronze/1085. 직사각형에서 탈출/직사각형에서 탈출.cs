using System;
using System.Text;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        int x = int.Parse(input[0]);
        int y = int.Parse(input[1]);
        int width = int.Parse(input[2]);
        int height = int.Parse(input[3]);
        int min = x <= y ? x : y;
        min = width - x <= min ? width - x : min;
        min = height - y<= min ? height - y : min;



        Console.WriteLine(min);
    }

}