using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        Reverse(ref s[0]);
        Reverse(ref s[1]);
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        Console.WriteLine(a >= b ? a : b);
    }
    static void Reverse(ref string s)
    {
        char[] temp = s.ToCharArray();
        Array.Reverse(temp);
        //return new string(temp);
        s = new string(temp);
    }
}