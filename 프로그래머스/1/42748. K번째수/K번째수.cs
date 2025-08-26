using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int answerCount = commands.GetLength(0);
        int[] answer = new int[answerCount];

        for(int i = 0;i<commands.GetLength(0);i++)
        {

            int length = commands[i, 1] - commands[i, 0]+1;
            int[] temp = new int[length];
            Array.Copy(array,commands[i,0]-1,temp,0, length);
            Array.Sort(temp);

            answer[i] = temp[commands[i, 2]-1];
        }

        return answer;
    }
}