using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string[] ss = s.Split(' ');
        int a = int.Parse(ss[0]);
        int b = int.Parse(ss[1]);
        int c = int.Parse(ss[2]);
        int total = 0;
        if(a == b && a == c)
        {
            total = 10000 + a * 1000;
        }
        else if (a == b && a != c)
        {
            total = 1000 + a * 100;
        }
        else if (a == c && a != b)
        {
            total = 1000 + a * 100;
        }
        else if (b == c && b != a)
        {
            total = 1000 + b * 100;
        }
        else
        {
            total = b * 100;
            if(a > b || c > b)
            {
                total = c * 100;
                if (a>c)
                {
                    total = a * 100;
                }
                
            }
        }
        Console.WriteLine(total);
    }
}