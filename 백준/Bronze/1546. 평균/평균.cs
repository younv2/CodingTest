using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int ea = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ');

        double[] ints = new double[ea];
        
        for(int i=0;i< ints.Length; i++)
        {
            ints[i] = int.Parse(s[i]);
        }
        double max = ints.Max();
        for(int i = 0; i < ints.Length; i++)
        {
            
                ints[i] = (ints[i] / max) * 100;
            
        }
        double total = 0;
        for(int i = 0; i < ints.Length; i++)
        {
            total += ints[i];
        }
        Console.WriteLine(total/ints.Length);
    }
}