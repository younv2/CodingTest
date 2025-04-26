using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int firstCnt = int.Parse(Console.ReadLine());
        int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int secCnt = int.Parse(Console.ReadLine());
        int[] secArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Dictionary<int, int> dic = new Dictionary<int, int>();

        for(int i = 0; i < secCnt; i++)
        {
            dic[secArr[i]] = 0;
        }
        for(int j =0;  j < firstArr.Length; j++)
        {
            if(dic.ContainsKey(firstArr[j]))
            {
                dic[firstArr[j]]++;
            }
        }

        StringBuilder sb = new StringBuilder();
        for(int i=0; i < secCnt; i++)
        {
            sb.Append(dic[secArr[i]]);
            if(i != secCnt - 1)
            {
                sb.Append(" ");
            }
        }
        Console.WriteLine(sb.ToString());
    }
}
