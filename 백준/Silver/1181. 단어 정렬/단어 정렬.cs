
using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        HashSet<string> hashArr = new HashSet<string>();
        string[] arr;
        for(int i = 0; i < input; i++)
        {
            string inputStr = Console.ReadLine();

            hashArr.Add(inputStr);
        }
        arr = new string[hashArr.Count];
        hashArr.CopyTo(arr);
        QuickSort(arr,0,arr.Length-1);
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < arr.Length; i++)
        {
            sb.AppendLine(arr[i]);
        }
        Console.WriteLine(sb.ToString());
    }
    public static void QuickSort(string[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    private static int Partition(string[] arr, int low, int high)
    {
        string pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j].Length < pivot.Length)
            {
                i++;
                Swap(arr, i, j);
            }
            else if (arr[j].Length == pivot.Length && String.Compare(arr[j], pivot) < 0)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return i + 1;
    }

    private static void Swap(string[] arr, int a, int b)
    {
        string temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}