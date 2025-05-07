public class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        HashSet<string> list = new HashSet<string>();
        for(int i = 0; i< str.Length; i++)
        {
            for(int j = i; j < str.Length; j++)
            {
                list.Add(str.Substring(i, str.Length - j));
            }
        }
        Console.WriteLine(list.Count);
    }
}