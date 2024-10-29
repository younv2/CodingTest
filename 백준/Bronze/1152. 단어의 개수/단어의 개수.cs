using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine().Trim();
        
        string[] args = s.Split(' ');
        if(s.Length==0)
        {
            Console.WriteLine(s.Length);
        }
        else
        {
            Console.WriteLine(args.Length);    
        }
    }
}