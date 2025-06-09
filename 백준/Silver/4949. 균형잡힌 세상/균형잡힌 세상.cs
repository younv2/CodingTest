public class Program
{
    static void Main(string[] args)
    {
        for (;;)
        {
            string input = Console.ReadLine();
            if (input == ".") break;

            if (input[^1] != '.')
            {
                Console.WriteLine("no");
                continue;
            }

            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;

            for (int i = 0; i < input.Length - 1; i++)
            {
                char c = input[i];

                if (c == '(' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        isBalanced = false;
                        break;
                    }
                }
                else if (c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[')
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isBalanced && stack.Count == 0 ? "yes" : "no");
        }
    }
}