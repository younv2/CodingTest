using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        int cards1Index = 0;
        int cards2Index = 0;
        for(int i = 0; i<goal.Length; i++)
        {
            if(cards1Index < cards1.Length && cards1[cards1Index] == goal[i])
            {
                cards1Index++;
            }
            else if(cards2Index < cards2.Length && cards2[cards2Index] == goal[i])
            {
                cards2Index++;
            }
            else
            {
                answer = "No";
            }
        }
        
        return answer;
    }
}