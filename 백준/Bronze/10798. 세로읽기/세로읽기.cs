using System;

class Program
{
    static void Main()
    {
        string[] s = new string[5];
        for (int i = 0; i < 5; i++) 
        {
            s[i] = Console.ReadLine();
        }
        for(int i = 0;i < 15; i++)
        {
            for(int j = 0;j < 5;j++)
            {
                if (i < s[j].Length)
                    Console.Write(s[j][i]);
            }
        }
    }
}