using System;
using System.Linq;
using System.Text;
class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        int num = int.Parse(Console.ReadLine());
        for(int i =0; i < num; i++)
        { 
            list.Add(int.Parse(Console.ReadLine()));
        }
        Sort(ref list);
        for(int i=0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
    static void Sort(ref List<int> num)
    {
        int temp = 0;
        for(int i =1; i < num.Count; i++)
        {
            for(int j = 0; j< num.Count - i; j++)
            {
                if (num[j] > num[j + 1])
                {
                    temp = num[j];
                    num[j] = num[j + 1];
                    num[j + 1] = temp;
                }
            } 
        }
    }
}