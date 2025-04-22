using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
        HashSet<string> firstStr = new HashSet<string>();
        for (int i = 0; i < inputs[0]; i++)
            firstStr.Add(Console.ReadLine());
        string[] secondStr = new string[inputs[1]];
        for (int i = 0; i < secondStr.Length; i++)
        {
            secondStr[i] = Console.ReadLine();
            if (firstStr.Contains(secondStr[i]))
                count++;
        }

        Console.WriteLine(count);
    }
}