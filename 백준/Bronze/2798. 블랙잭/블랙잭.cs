using System;
using System.Text;
class Program
{
    static void Main()
    {
        string[] temp = Console.ReadLine().Split(" ");
        int cards = int.Parse(temp[0]);
        int max = int.Parse(temp[1]);
        int[] cardNums = new int[cards];
        int total = 0;
        string[] temps = Console.ReadLine().Split(" ");
        for (int i=0; i<cards; i++)
        {
            cardNums[i] = int.Parse(temps[i]);
        }
        
        for(int i =0; i<cardNums.Length; i++)
        {
            for(int j = 0; j< cardNums.Length; j++)
            {
                for (int k = 0; k < cardNums.Length; k++)
                { 
                    if(i!=j&&j!=k&&i!=k)
                    {
                        int a = cardNums[i] + cardNums[j] + cardNums[k];
                        if (a <= max && a > total)
                        {
                            total = a;
                        }
                    }
                }
            }
        }
        Console.WriteLine(total);
    }
}