// 시간 제한과 입력 조건 값이 매우 큼 O(n^2)이상으로 되면 안되는 것을 알 수 있음
// 조건 값을 초과한 합의 갯수를 찾으면 되기 때문에 크기 순으로 정렬을 해도 문제가 없을 것으로 판단.
// 정렬의 경우 퀵 정렬을 이용하기 때문에 O(NlogN)이므로 탐색으로 O(n^2)이 나오는것보다 훨씬 빠름
// 크기가 가장 작은 원소와 가장 큰원소-> 작은원소를 찾아가며 합이 조건과 같은 값을 찾고 더함.
// 서로 다른 양의 정수이기 때문에 쌍이 한 원소에 다른 값이 있을 경우가 없으므로 다음 작은 원소로 비교

//-----------------------------------------------------시간 초과---------------------------------
// 이중 for문을 쓰고 결국 최악의 조건이면 O(N^2)으로 돌게 된다는 것을 확인
// 투 포인터에 대해서 다시 확인 후 수정
// 작은 원소 + 큰 원소의 값이 일치 할 때 해당 작은 원소와 큰 원소는 더이상 확인할 이유가 없으므로 넘김
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[] ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int condition = int.Parse(Console.ReadLine());
        int answer = 0;

        int head = 0, tail = ints.Length-1;

        Array.Sort(ints);

        while(true)
        {
            if (head >= tail)
                break;
            if (ints[head] + ints[tail] == condition)
            {
                answer++;
                head++;
                tail--;
            }
            else if (ints[head] + ints[tail] < condition)
            {
                head++;
            }
            else if (ints[head] + ints[tail] > condition)
            {
                tail--;
            }
        }

        Console.WriteLine(answer);
    }
}