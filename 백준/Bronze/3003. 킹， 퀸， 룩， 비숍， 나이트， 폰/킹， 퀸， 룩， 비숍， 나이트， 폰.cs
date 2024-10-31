using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int[] ints = new int[s.Length];
        for(int i = 0;i<ints.Length;i++) ints[i] = int.Parse(s[i]);
        for(int i = 0;i<ints.Length;i++)
        {
            if (i == 0 || i == 1)
                ints[i] = 1 - ints[i];
            else if (i >1 && i<5)
                ints[i] = 2 - ints[i];
            else
                ints[i] = 8 - ints[i];
            Console.Write(ints[i] + " ");
        }

    }
}