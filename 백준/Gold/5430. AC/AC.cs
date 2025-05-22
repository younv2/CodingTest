
/*
[입력값]
    첫번째 - 테스트 케이스 개수 T(max = 100)
    테스트 케이스 첫번째 - 수행할 함수D(테스트 케이스 배열의 첫번째 값 제거),R(배열 뒤집기)(max = 10만)
    테스트 케이스 두번째 - 테스트 케이스 배열의 길이(max = 10만)
    테스트 케이스 세번째 - 테스트 케이스 배열(각 인수의 값은 0~100)

[시도 방식]
    List - RemoveAt -> 테스트케이스 배열의 길이가 10만일 수 있기때문에 시간에 치명적
    head와 tail을 이용하여 실제 값을 지우지 않고 작성.
 */
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string tcMethod = Console.ReadLine();
            
            int tcLength = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string[] tcArray = input.Substring(1, input.Length - 2).Split(',');
            int head = 0;
            int tail = 0;

            bool isR = false;
            for(int j = 0; j<tcMethod.Length;j++)
            {
                if (tcMethod[j] == 'D')
                {
                    if (isR)
                        tail++;
                    else
                        head++;
                    
                }
                else if (tcMethod[j] == 'R') 
                {
                    isR = !isR;
                }
            }
            
            if(isR)
            {
                int temp = head;
                head = tail;
                tail = temp;
                Array.Reverse(tcArray);
            }
            if (head + tail > tcLength)
            {
                sb.AppendLine("error");
            }
            else
            {
                sb.Append("[");
                for (int j = head; j < tcArray.Length - tail; j++)
                {
                    sb.Append(tcArray[j]);
                    if (j < tcArray.Length - 1 - tail)
                        sb.Append(',');
                }
                sb.AppendLine("]");
            }
        }
        Console.WriteLine(sb.ToString());
    }
}