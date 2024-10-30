using System;

class Program
{
    static void Main()
    {
        string letters = Console.ReadLine();
        int ans = 0;
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == 'A' || letters[i] == 'B' || letters[i] == 'C')
            {
                ans += 3;
            }
            else if (letters[i] == 'D' || letters[i] == 'E' || letters[i] == 'F')
            {
                ans += 4;
            }
            else if (letters[i] == 'G' || letters[i] == 'H' || letters[i] == 'I')
            {
                ans += 5;
            }
            else if (letters[i] == 'J' || letters[i] == 'K' || letters[i] == 'L')
            {
                ans += 6;
            }
            else if (letters[i] == 'M' || letters[i] == 'N' || letters[i] == 'O')
            {
                ans += 7;
            }
            else if (letters[i] == 'P' || letters[i] == 'Q' || letters[i] == 'R' || letters[i] == 'S')
            {
                ans += 8;
            }
            else if (letters[i] == 'T' || letters[i] == 'U' || letters[i] == 'V')
            {
                ans += 9;
            }
            else
            {
                ans += 10;
            }
        }
        Console.WriteLine(ans);
    }
}