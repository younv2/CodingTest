public class Program
{
    static void Main(string[] args)
    {
        int sugarWeight3 = 3;
        int sugarWeight5 = 5;

        int sugar3Count = 0;
        int sugar5Count = 0;

        int totalCount = -1;

        int input = int.Parse(Console.ReadLine());
        sugar5Count = input / sugarWeight5;
        for(int i = 0; i <= sugar5Count; sugar5Count--)
        {
            var leftWeight = input - (sugarWeight5 * sugar5Count);

            if (leftWeight % sugarWeight3 == 0)
            {
                sugar3Count = leftWeight / sugarWeight3;
                totalCount = sugar3Count + sugar5Count;
                break;
            }
        }
        Console.WriteLine(totalCount);
    }
}