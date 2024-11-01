using System;

class Program
{
    static void Main()
    {
        for(; ; )
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            if (a == 0 && b == 0)
            {
                break;
            }
            Console.WriteLine(a + b);
            
        }
        
    }
}