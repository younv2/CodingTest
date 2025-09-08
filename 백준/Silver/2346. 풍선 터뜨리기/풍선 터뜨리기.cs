using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[] ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var list = new List<(int idx, int step)>(count);
        for (int i = 0; i < count; i++)
            list.Add((i + 1, ints[i]));

        StringBuilder sb = new StringBuilder();
        int cur = 0;

        for (int i = 0; i < count; i++)
        {
            var (idx, step) = list[cur];
            sb.Append(idx).Append(' ');
            list.RemoveAt(cur);

            if (list.Count == 0) break;

            if (step > 0)
                cur = (cur + (step - 1)) % list.Count;
            else
            {
                cur = (cur + step) % list.Count;
                if (cur < 0) cur += list.Count;
            }
        }

        Console.WriteLine(sb.ToString().TrimEnd());
    }
}