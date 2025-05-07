using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        Stack stack = new Stack(count);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            int[] ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            switch (ints[0])
            {
                case 1:
                    stack.Push(ints[1]);
                    break;
                case 2:
                    sb.AppendLine(stack.Pop().ToString());
                    break;
                case 3:
                    sb.AppendLine(stack.GetCount().ToString());
                    break;
                case 4:
                    sb.AppendLine(stack.IsEmpty().ToString());
                    break;
                case 5:
                    sb.AppendLine(stack.Peek().ToString());
                    break;
            }
        }
        Console.WriteLine(sb.ToString());

    }
}
public class Stack
{
    private int[] arr;
    private int tail = -1;
    public Stack(int capacity)
    {
        arr = new int[capacity];
    }
    public int Pop()
    {
        if(tail != -1)
        {
            int result = arr[tail--];
            return result;
        }
        else
            return -1;
    }
    public int Peek()
    {
        if (tail != -1)
        {
            int result = arr[tail];
            return result;
        }
        else
            return -1;
    }
    public void Push(int x)
    {
        arr[++tail] = x;
    }
    public int IsEmpty()
    {
        if (tail == -1)
            return 1;
        else
            return 0;
    }
    public int GetCount()
    {
        return tail + 1;
    }
}