using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine().ToUpper();
        int[] al = new int[26];
        int max = 0;
        char maxT = '\0';
        for(int j = 0; j < str.Length; j++)
        {
            for (int i = 0; i < al.Length; i++)
            {
                char temp = (char)('A' + i);
                if (str[j] == temp)
                {
                    al[i]++;
                    if (max < al[i])
                    {
                        max = al[i];
                        maxT = temp;
                    }
                    else if (max == al[i])
                    {
                        maxT = '?';
                    }
                }
                    
            }
        }
        Console.WriteLine(maxT);
        
    }
}