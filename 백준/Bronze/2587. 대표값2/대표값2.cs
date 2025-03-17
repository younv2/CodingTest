using System;
using System.Linq;
using System.Text;
class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        int num = 5;
        int total = 0;
        for(int i =0; i < num; i++)
        { 
            list.Add(int.Parse(Console.ReadLine()));
        }
        Sort(ref list);
        for(int i=0; i < list.Count; i++)
        {
            total += list[i];
            
        }
        total /= num;
        Console.WriteLine(total);
        Console.WriteLine(list[2]);
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