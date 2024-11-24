using System;
class Program
{
    static void Main()
    {
        int cnt = int.Parse(Console.ReadLine());

        int i = 0;
        for (int sum = 2; sum <= cnt; i++)
            sum += 6 * i;
        if (cnt == 1)
            i = 1;
        Console.WriteLine(i);
    }
}