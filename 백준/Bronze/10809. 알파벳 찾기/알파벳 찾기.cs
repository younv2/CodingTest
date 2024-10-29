using System;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();

        int[] alpha = new int[26];
        for(int i=0;i<alpha.Length; i++)
        {
            char temp = (char)('a' + i);
            if(s.IndexOf(temp) != -1)
            {
                alpha[i] = s.IndexOf(temp);
                continue;
            }
            alpha[i] = -1;
        }
        for(int i = 0; i < alpha.Length; i++)
            Console.Write(alpha[i] + " ");
    }
}