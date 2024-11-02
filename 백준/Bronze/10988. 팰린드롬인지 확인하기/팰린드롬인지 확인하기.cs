using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        bool b = true;

        for(int i = 0; i < str.Length; i++)
        {
            if (str[str.Length-1 - i] != str[i])
            {
                b= false;
                break;
            }   
            
        }
        Console.WriteLine(b == true ? '1' : '0');


    }
}