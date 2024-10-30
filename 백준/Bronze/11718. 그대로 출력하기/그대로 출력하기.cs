using System;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        int i = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                break;
            }
            list.Add(input);
        }
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }
    }
}