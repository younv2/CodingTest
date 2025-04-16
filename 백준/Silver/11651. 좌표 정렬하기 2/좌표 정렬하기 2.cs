
using System;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {

        int input = int.Parse(Console.ReadLine());
        (int x, int y)[] arr = new (int x, int y)[input];
        for(int i = 0; i < input; i++)
        {
            string[] inputStr = Console.ReadLine().Split(' ');

            arr[i] = (int.Parse(inputStr[1]), int.Parse(inputStr[0]));
        }
        Array.Sort(arr);

        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < arr.Length; i++)
        {
            sb.AppendLine(arr[i].y + " " + arr[i].x);
        }
        Console.WriteLine(sb.ToString());

    }
}