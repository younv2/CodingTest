using System;

class Program
{
    static void Main()
    {
        int[] b = new int[10];
        
        int result = 0;
        for(int i=0;i<10;i++)
        {
            int num = int.Parse(Console.ReadLine());
            b[i] = num%42;
        }

        for(int i = 0; i<10; i++)
        {
            int count = 0;
            for (int j = i+1; j<10; j++) 
            {
                if (b[i] == b[j])
                {
                    count++;
                }   
            }
            if (count == 0)
                result++;
        }
        Console.WriteLine(result);

    }
}