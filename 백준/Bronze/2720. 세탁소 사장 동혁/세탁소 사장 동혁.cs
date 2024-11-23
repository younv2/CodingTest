using System;

class Program
{
    static void Main()
    {
        int quarter = 0;
        int dime = 0;
        int nickel = 0;
        int penny = 0;
        int time = int.Parse(Console.ReadLine());
        for(int i = 0;  i < time; i++)
        {
            int price = int.Parse(Console.ReadLine());
            quarter = price / 25;
            price = price % 25;
            dime = price / 10;
            price = price % 10;
            nickel = price / 5;
            price = price % 5;
            penny = price / 1;

            Console.WriteLine($"{quarter} {dime} {nickel} {penny}");
        }
    }
}