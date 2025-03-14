using System;
using System.Text;
class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        for (int i = 2; i <= input; i++)
        {
            for (; ; )
            {
                if (input % i == 0)
                {
                    input /= i;
                    Console.WriteLine(i);
                }
                else
                    break;
            }
        }
    }


}