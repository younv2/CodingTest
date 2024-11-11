using System;

class Program
{
    static void Main()
    {
        string[] temp = Console.ReadLine().Split();

        int num = int.Parse(temp[0]);
        int jb = int.Parse(temp[1]);
        string total = "";
        while (true)
        {
            int tem = num % jb;
            if(tem >= 10)
            {
                total += (char)('A' + (tem - 10));
            }
            else if(tem < 10)
            {
                total += (char)(tem + '0');
            }
            if (num < jb) break;
            num = num / jb;
            
        }
        string ans = new String(total.Reverse().ToArray());
        Console.WriteLine(ans);
    }
}