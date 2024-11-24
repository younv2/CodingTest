using System;

class Program
{
    static void Main()
    {
        int cnt = int.Parse(Console.ReadLine());
        int total = 2;
        for(int i =0; i < cnt; i++)
        {
            total += total -1;
        }
        Console.WriteLine(total * total);
    }
}