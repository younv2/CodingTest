using System;
using System.Text;
class Program
{
    struct Point
    {
        public int x;
        public int y;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Point> p = new List<Point>();
        int minX, minY, maxX, maxY;
        int extent =0;
        for (int i =0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(" ");

            p.Add(new Point() 
            { 
                x = int.Parse(s[0]), 
                y = int.Parse(s[1]) 
            });
        }
        minX = maxX = p[0].x;
        minY = maxY = p[0].y;
        for (int i = 1; i < p.Count;i++)
        {
            if (p[i].x < minX)
                minX = p[i].x;
            if (p[i].y < minY)
                minY = p[i].y;
            if (p[i].x > maxX)
                maxX = p[i].x;
            if (p[i].y > maxY)
                maxY = p[i].y;
        }
        extent = (maxX - minX) * (maxY - minY);
        Console.WriteLine(extent);
    }

}