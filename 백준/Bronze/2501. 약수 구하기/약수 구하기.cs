using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int fir = int.Parse(input[0]);
        int sec = int.Parse(input[1]);
        int cnt = 0;
        int ans = 0;

        for(int i =1; i<=fir; i++)
        {
            if (fir % i == 0)
                cnt++;
            if (cnt == sec)
            {
                ans = i;
                break;
            }
        }
        if (cnt == sec)
            Console.WriteLine(ans);
        else
            Console.WriteLine(0);

    }
}