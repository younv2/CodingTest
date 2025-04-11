using System;
using System.Text;
public class AffordableVacation
{
    public static string FindMinCost(int money, int days, int[] cost)
    {
        int n = cost.Length;

        // 슬라이딩 윈도우 함수: 길이 d인 구간 중 최소합 반환
        int GetMinCost(int d)
        {
            int windowSum = 0;
            for (int i = 0; i < d; i++)
                windowSum += cost[i];

            int minSum = windowSum;

            for (int i = d; i < n; i++)
            {
                windowSum += cost[i] - cost[i - d];
                minSum = Math.Min(minSum, windowSum);
            }

            return minSum;
        }

        // 먼저 현재 days로 가능한지 확인
        int minCost = GetMinCost(days);
        if (minCost <= money)
            return $"money: {minCost}";

        // 이진 탐색으로 최대 가능 days 찾기 (1 ~ days-1)
        int left = 0;
        int right = days - 1;
        int maxValidDays = 0;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (mid == 0 || GetMinCost(mid) <= money)
            {
                maxValidDays = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return $"days: {maxValidDays}";
    }
}