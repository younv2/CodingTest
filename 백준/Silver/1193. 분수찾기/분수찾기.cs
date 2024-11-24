using System;
class Program
{
    static void Main()
    {
        int cnt = int.Parse(Console.ReadLine());

        int i = 0;
        for (; cnt > i; i++)
            cnt -= i;
        if (i % 2 == 1)
            Console.WriteLine($"{i + 1 - cnt}/{cnt}");
        else
            Console.WriteLine($"{cnt}/{i + 1 - cnt}");
    }
}