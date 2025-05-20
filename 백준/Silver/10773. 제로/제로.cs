using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        Stack stack = new Stack(count);
        int total = 0;
        int stackCount;
        for(int i = 0; i < count; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                stack.Pop();
                continue;
            }
            stack.Push(num);
        }
        stackCount = stack.GetCount();
        for(int i = 0; i < stackCount; i++)
        {
            total += stack.Pop();
        }

        Console.WriteLine(total);
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
        if (tail != -1)
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