using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for(int i = 1; i <= num; i++)
        {
            for (int j = i; j < num; j++)
            {
                Console.Write(" ");
            }
            for(int k = num*2-1; k > (num * 2 - 1) - (i*2-1); k--)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
        for (int i = num; i > 1; i--)
        {
            for (int j = i; j <= num; j++)
            {
                Console.Write(" ");
            }
            for (int k = (num-1) * 2 - 1; k > (num * 2 - 1) - (i * 2 - 1); k--)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }


    }
}