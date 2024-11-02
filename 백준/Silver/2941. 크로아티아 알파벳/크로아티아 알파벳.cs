using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        int cnt = 0;
        for(int j = 0; j < str.Length; j++)
        {
            if(j != 0 && str[j] == 'j')
                if (str[j - 1] == 'l' || str[j - 1] == 'n')
                    continue;
            if (j != 0 && str[j] == '-')
                if (str[j - 1] == 'c' || str[j - 1] == 'd')
                    continue;
            if (j > 1 && str[j] == '=')
                if (str[j - 2] == 'd' && str[j - 1] == 'z')
                {
                    cnt--;
                    continue;
                }
            if (j != 0 && str[j] == '=')
                if (str[j - 1] == 'c' || str[j - 1] == 's' || str[j - 1] == 'z')
                    continue;
            
            cnt++;
        }
        Console.WriteLine(cnt);
        
    }
}