using System;
using System.Text;
class Program
{
    static void Main()
    {
        int[] nums = new int[3];
        int total = 0;
        for(int i = 0; i< nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
            total += nums[i];
        }
        if (total != 180)
        {
            Console.WriteLine("Error");
        }
        else
        {
            if (nums[0] == nums[1] && nums[1] == nums[2]) 
                Console.WriteLine("Equilateral");
            else if (nums[0] != nums[1] && nums[0] != nums[2] && nums[1] != nums[2])
                Console.WriteLine("Scalene");
            else
                Console.WriteLine("Isosceles");
        }
        
    }

}