using System;
using System.Text;
class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split(" ");
        int[] nums = new int[3]
            { int.Parse(s[0]),
                int.Parse(s[1]),
                int.Parse(s[2])
            };

        Sort(ref nums);
        if (nums[2] >= nums[1] + nums[0])
            nums[2] = nums[1] + nums[0]-1;
        Console.WriteLine(nums[0] + nums[1] + nums[2]);
    }
    static void Sort(ref int[] nums)
    {
        int temp;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i != nums.Length - 1 && nums[i] > nums[i + 1])
            {
                temp = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = temp;
            }
        }

    }

}