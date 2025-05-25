public class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        for(int i = 0; i < input; i++)
        {
            Stack<char> chars = new Stack<char>(Console.ReadLine().ToCharArray());
            int num = 0;
            int cnt = chars.Count;
            for (int j = 0; j < cnt; j++)
            {
                char temp = chars.Pop();
                if (temp == '(')
                {
                    num--;
                    if (num < 0)
                        break;
                }
                else if (temp == ')')
                {
                    num++;
                }
            }
                Console.WriteLine(num != 0 ? "NO" : "YES");
        }
    }
}