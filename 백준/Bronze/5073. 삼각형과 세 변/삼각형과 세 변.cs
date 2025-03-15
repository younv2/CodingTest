using System;
using System.Text;
class Program
{
    static void Main()
    {
        List<int[]> nums = new List<int[]>();
        while (true)
        {
            string[] s = Console.ReadLine().Split(" ");
            if (s[0] == "0" && s[1] == "0" && s[2] == "0")
            {
                break;
            }
            nums.Add(new int[3] {
                int.Parse(s[0]),
                int.Parse(s[1]),
                int.Parse(s[2])
            });

        }
        Sort(ref nums);
        foreach (var num in nums)
        {
            if (num[2] >= num[1] + num[0])
                Console.WriteLine("Invalid");
            else if (num[0] == num[1] && num[1] == num[2])
                Console.WriteLine("Equilateral");
            else if (num[0] != num[1] && num[0] != num[2] && num[1] != num[2])
                Console.WriteLine("Scalene");
            else
                Console.WriteLine("Isosceles");
        }
    }
    static void Sort(ref List<int[]> nums)
    {
        int temp;
        foreach (var data in nums)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (i != data.Length - 1 && data[i] > data[i + 1])
                {
                    temp = data[i];
                    data[i] = data[i + 1];
                    data[i + 1] = temp;
                }
            }
        }

    }

}