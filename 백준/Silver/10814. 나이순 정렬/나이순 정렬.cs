using System;
using System.Text;

public class Program
{

    static void Main(string[] args)
    {
        StringBuilder sb= new StringBuilder();
        string input = Console.ReadLine();
        int a = int.Parse(input);
        (int age, int idx, string name)[] values = new (int age, int idx, string name)[a];
        for(int i = 0;i < a;i++)
        {
            string[] inputArr = Console.ReadLine().Split(' ');

            values[i].idx = i + 1;
            values[i].age = int.Parse(inputArr[0]);
            values[i].name = inputArr[1];
        }
        Array.Sort(values);
        for(int i= 0;i<values.Length;i++)
        {
            sb.AppendLine(values[i].age + " " + values[i].name);
        }
        Console.WriteLine(sb.ToString());
       
        
    }
}
