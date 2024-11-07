using System;

class Program
{
    struct MATRIX
    {
        public int[,] map;
    }
    static void Main()
    {
        string[] size = Console.ReadLine().Split();
        int height = int.Parse(size[0]);
        int width = int.Parse(size[1]);

        MATRIX a,b,total;
        a.map = new int[height, width];
        b.map = new int[height, width];
        total.map = new int[height, width];
        for (int i = 0; i < height; i++)
        {
            string[] temp = Console.ReadLine().Split();
            for(int j = 0; j < width; j++)
            {
                a.map[i, j] = int.Parse(temp[j]);
            }
        }
        for (int i = 0; i < height; i++)
        {
            string[] temp = Console.ReadLine().Split();
            for (int j = 0; j < width; j++)
            {
                b.map[i, j] = int.Parse(temp[j]);
                total.map[i,j] = a.map[i, j] + b.map[i, j];
            }
        }
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(total.map[i, j]);
                if (j != width - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}