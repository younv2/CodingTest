using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        //2 4 -10 4 -9
        //2 3  0  3  1
        string[] inputs = Console.ReadLine().Split(' ');
        int[] temp = new int[inputs.Length];
        for(int i = 0; i<inputs.Length; i++)
        {
            temp[i] = int.Parse(inputs[i]);
        }
        HashSet<int> ints = new HashSet<int>(temp.ToList());
        List<int> intList = ints.ToList();
        intList.Sort();
        Dictionary<int, int> intDic = new Dictionary<int, int>();
        for(int i = 0; i< intList.Count; i++)
        {
            intDic.Add(intList[i], i);
        }
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i<temp.Length;i++)
        {
            sb.Append(intDic[temp[i]]);
            if(i != temp.Length - 1)
            sb.Append(" ");
        }
        Console.WriteLine(sb.ToString());
    }
}