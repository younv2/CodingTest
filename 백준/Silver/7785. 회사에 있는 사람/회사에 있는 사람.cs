using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static HashSet<string> list = new HashSet<string>();
    static void Main(string[] args)
    {
        
        int input = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < input; i++)
        {
            string[] strings = Console.ReadLine().Split(' ');
            if (String.Equals("enter", strings[1]))
            {
                Enter(strings[0]);
            }
            else if(String.Equals("leave", strings[1]))
            {
                Exit(strings[0]);
            }
        }
        var temp = list.ToArray();
        Array.Sort(temp);
        Array.Reverse(temp);
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<list.Count; i++)
        {
            sb.Append(temp[i]);
            if(i!=temp.Length-1)
                sb.AppendLine();
        }
        Console.WriteLine(sb.ToString());
    }
    static void Enter(string input)
    {
        list.Add(input);
    }
    static void Exit(string input)
    {
        list.Remove(input);
    }
}