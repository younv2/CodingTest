using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[] cnt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        HashSet<int> set = firstArr.ToHashSet();

        int[] secArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        HashSet<int> set2 = secArr.ToHashSet();
        foreach(var data in firstArr)
        {
            if (set2.Contains(data))
                set2.Remove(data);
        }
        foreach (var data in secArr)
        {
            if(set.Contains(data))
                set.Remove(data);
        }
        Console.WriteLine(set.Count + set2.Count);

    }
}
