using System;

class Program
{
    static void Main()
    {
        double majTotal = 0;
        double total = 0;
        double[] score = new double[20];
        string[] str = new string[20];
        int pCnt = 0;
        
        for(int i =0;i<str.Length;i++)
        {
            str[i] = Console.ReadLine();
            switch (str[i].Split(' ')[2])
            {
                case "A+":
                    score[i] = double.Parse(str[i].Split(' ')[1]) * 4.5;
                    break;
                case "A0":
                    score[i] = double.Parse(str[i].Split(' ')[1]) * 4;
                    break;
                case "B+":
                    score[i] = double.Parse(str[i].Split(' ')[1]) * 3.5;
                    break;
                case "B0":
                    score[i] = double.Parse(str[i].Split(' ')[1]) * 3;
                    break;
                case "C+":
                    score[i] = double.Parse(str[i].Split(' ')[1]) * 2.5;
                    break;
                case "C0":
                    score[i] = double.Parse(str[i].Split(' ')[1]) * 2;
                    break;
                case "D+":
                    score[i] = double.Parse(str[i].Split(' ')[1]) * 1.5;
                    break;
                case "D0":
                    score[i] = double.Parse(str[i].Split(' ')[1]) * 1;
                    break;
                case "F":
                    score[i] = double.Parse(str[i].Split(' ')[1]) * 0;
                    break;
                case "P":
                    pCnt++;
                    break;

            }
            total += score[i];
            if(str[i].Split(' ')[2] != "P")
                majTotal += double.Parse(str[i].Split(' ')[1]);
        }
        Console.WriteLine(total / majTotal);
        
    }
}