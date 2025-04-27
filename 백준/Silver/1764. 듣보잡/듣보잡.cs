using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[] cnt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string[] firstArr = new string[cnt[0]];
        for (int i = 0;i<firstArr.Length;i++)
        {
            firstArr[i] = Console.ReadLine();
        }
        HashSet<string> set = new HashSet<string>();

        set = firstArr.ToHashSet();
        string[] secArr = new string[cnt[1]];

        List<string> list = new List<string>();
        for (int i = 0; i < secArr.Length; i++)
        {
            secArr[i] = Console.ReadLine();
            if(set.Contains(secArr[i]))
                list.Add(secArr[i]);
        }
        list.Sort();
        

        StringBuilder sb = new StringBuilder();
        sb.AppendLine(list.Count.ToString());
        for(int i=0; i < list.Count; i++)
        {
            sb.AppendLine(list[i]);
        }
        Console.WriteLine(sb.ToString());
    }
}
