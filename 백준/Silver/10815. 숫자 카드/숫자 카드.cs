using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int firstCount = int.Parse(Console.ReadLine());
        var firstInts = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));
        int secondCount = int.Parse(Console.ReadLine());
        int[] secondInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] result = new int[secondCount];
        for(int i = 0; i<secondCount; i++)
        {
            result[i] = firstInts.Contains(secondInts[i]) ? 1 : 0;
        }
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i<result.Length; i++)
        {
            sb.Append(result[i]);
            if(i!=result.Length-1) 
                sb.Append(' ');

        }
        Console.WriteLine(sb.ToString());
    }
}