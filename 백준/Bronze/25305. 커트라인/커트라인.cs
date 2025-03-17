using System;
using System.Linq;
using System.Text;
class Program
{
    static void Main()
    {
        string[] sTemp = Console.ReadLine().Split(" ");
        int num = int.Parse(sTemp[0]);
        int cutline = int.Parse(sTemp[1]);
        sTemp = Console.ReadLine().Split(" ");
        List<int> list = new List<int>();
        for(int i =0; i < num; i++)
        {
            list.Add(int.Parse(sTemp[i]));
        }
        Sort(ref list);

        Console.WriteLine(list[cutline-1]);
    }
    static void Sort(ref List<int> num)
    {
        int temp = 0;
        for(int i =1; i < num.Count; i++)
        {
            for(int j = 0; j< num.Count - i; j++)
            {
                if (num[j] < num[j + 1])
                {
                    temp = num[j];
                    num[j] = num[j + 1];
                    num[j + 1] = temp;
                }
            } 
        }
    }
}