using System;
using System.Text;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int ans = 0;

        for (int i = 0; i < num; i++)
        {
            if(num == GetSum(i))
            {
                ans = i;
                break;
            }
        }
        Console.WriteLine(ans);
    }
    static int GetSum(int num)
    {
        int temp = num;
        string sTemp = num.ToString();
        for(int i = 0; i < sTemp.Length; i++)
        {
            temp+= int.Parse(sTemp[i].ToString());
        }
        return temp;
    }
}