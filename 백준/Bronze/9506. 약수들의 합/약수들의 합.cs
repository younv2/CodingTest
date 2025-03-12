using System;
using System.Text;
class Program
{
    static void Main()
    {
        
        while(true)
        {
            int input = int.Parse(Console.ReadLine());
            if (input == -1)
                break;
            List<int> list = new List<int>();

            for(int i =1; i < input; i++)
            {
                if(input%i==0)
                {
                    list.Add(i);
                }
            }
            int total = 0;
            foreach(int i in list)
            {
                total += i;
            }
            if(total != input)
            {
                Console.WriteLine($"{input} is NOT perfect.");
            }
            else
            {
                StringBuilder sb = new StringBuilder($"{input} = ");

                for (int i = 0; i < list.Count; i++)
                {
                    sb.Append($"{list[i]}");
                    if(i!= list.Count-1)
                        sb.Append(" + ");
                }
                Console.WriteLine(sb);
            }
                
        }
    }
}