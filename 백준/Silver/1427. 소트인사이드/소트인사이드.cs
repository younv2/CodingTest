using System;

public class Program
{
    static void Main(string[] args)
    {
        char[] input = Console.ReadLine().ToCharArray();
        Sort(ref input);
        Console.Write(input);
        
    }
    static void Sort(ref char[] input)
    {
        for(int i =0;i<input.Length;i++)
        {
            for(int j  =0;j<input.Length;j++)
            {
                if (input[i] == input[j] || i == j)
                    continue;
                if (input[i] > input[j])
                {
                    char temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }
        }

    }
}
