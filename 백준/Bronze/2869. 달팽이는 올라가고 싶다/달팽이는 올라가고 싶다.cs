using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int up = int.Parse(input[0]);
        int down = int.Parse(input[1]);
        int height = int.Parse(input[2]) - up;
        
        int day = 1;
        day += (height / (up - down));
        if (height % (up - down) != 0)
            day++;
        Console.WriteLine(day);

    }
}