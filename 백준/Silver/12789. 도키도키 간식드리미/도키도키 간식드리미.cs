/*
 무조건 Goal에는 값이 순서대로 들어가야 한다.
 다른 하나의 길은 Stack구조로 되어 있어야 하며, Goal에 들어갈 번호를 찾을때, 
 첫번째 길과 두번째길의 원소를 둘다 확인해야한다.
 첫번째 길과 두번째 길에서 Goal을 들어갈 수있는 원소가 없다면 첫번째 길에서 두번째 길로 원소를 보낸다.
 두번째 길의 원소는 첫번째 길로는 돌아갈 수 없다.
 */
public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        int order = 1;
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == order)
            {
                order++;
            }
            else
            {
                while (stack.Count > 0 && stack.Peek() == order)
                {
                    stack.Pop();
                    order++;
                }

                stack.Push(array[i]);
            }
            
        }
        while (stack.Count > 0)
        {
            if (stack.Peek() == order)
            {
                stack.Pop();
                order++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(stack.Count>0 ? "Sad" : "Nice");
    }
}