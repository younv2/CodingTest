using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,string> dict = new Dictionary<int,string>();
        Dictionary<string,int> dict2 = new Dictionary<string, int>();
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[] strings2 = new string[input[1]];
        string[] result = new string[input[1]];
        for (int i = 0; i < input[0]; i++)
        {
            var temp = Console.ReadLine();
            dict.Add(i+1, temp);
            dict2.Add(temp, i + 1);
        }
        for (int i = 0; i < strings2.Length; i++)
        {
            strings2[i] = Console.ReadLine();
        }
        for(int i= 0; i < strings2.Length;i++)
        {
            if (int.TryParse(strings2[i],out int temp))
            {
                result[i] = dict[temp];
            }
            else
            {
                result[i] = dict2[strings2[i]].ToString();
            }
        }
        StringBuilder sb = new StringBuilder();
        for(int i=0; i< result.Length; i++)
        {
            sb.Append(result[i]);
            if(i!= result.Length-1)
                sb.AppendLine();
        }
        Console.WriteLine(sb.ToString());
    }
}