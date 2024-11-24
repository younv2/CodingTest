using System;
class Program
{
    static void Main()
    {
        for(; ; )
        {
            string[] input = Console.ReadLine().Split();
            int fir = int.Parse(input[0]);
            int sec = int.Parse(input[1]);

            if( fir == 0 &&sec == 0) {
                break;
            }
            if (sec % fir == 0)
            {
                Console.WriteLine("factor");
            }
            else if (fir % sec == 0)
            {
                Console.WriteLine("multiple");
            }
            else
                Console.WriteLine("neither");
        }
        

    }
}