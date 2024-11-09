using System;

class Program
{
    static void Main()
    {
        string[] temp = Console.ReadLine().Split();

        string num = temp[0];
        int jb = int.Parse(temp[1]);
        int[] ints = new int[num.Length];
        int total = 0;
        for(int i = 0; i< num.Length; i++)
        {
            int tempNum = 0;
            if (num[i] >= '0' && num[i] <= '9')
                tempNum = num[i] - '0';
            else if (num[i] >= 'A' && num[i] <= 'Z')
                tempNum = num[i] - 'A' + 10;
            for(int j = 0; j < num.Length - i -1; j++)
            {
                tempNum *= jb;
            }
            ints[i] = tempNum;
        }
        for(int i = 0; i< ints.Length;i++)
        {
            total += ints[i];
        }
        Console.WriteLine(total);
    }
}