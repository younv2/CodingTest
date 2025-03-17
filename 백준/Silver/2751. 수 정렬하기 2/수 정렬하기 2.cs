using System;
using System.Linq;
using System.Text;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] list = new int[num];
        
        for(int i =0; i < num; i++)
        { 
            list[i]= (int.Parse(Console.ReadLine()));
        }
        Array.Sort(list);
        string result = string.Join("\n", list);
        Console.WriteLine(result);
    }
}