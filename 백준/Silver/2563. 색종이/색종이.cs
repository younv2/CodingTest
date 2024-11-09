using System;

class Program
{
    static void Main()
    {
        int[,] dp = new int[100,100];

        int inputCnt = int.Parse(Console.ReadLine());
        int total = 0;
        for(int i = 0; i < inputCnt; i++)
        {
            string[] temp = Console.ReadLine().Split();
            int height = int.Parse(temp[0]);
            int width = int.Parse(temp[1]);

            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    dp[height + j, width + k] = 1;
                }
            }
        }
        for (int j = 0; j < 100; j++)
        {
            for (int k = 0; k < 100; k++)
            {
                if(dp[j, k] == 1)
                {
                    total++;
                }
            }
        }

        Console.WriteLine(total);
    }
}