using System;

// 짝수층은 정방향, 홀수층은 역방향으로 숫자가 나열된다.
// 2차원 배열로 짜게 되면 훨씬 편할 수 있지만 메모리를 훨씬 많이 먹게 된다.
// 최대 높이를 구하고 내가 꺼내고자 하는 박스가 몇번째 층에 있는지만 구하면 해결할 수 있지 않을까?
// 몇번째 위치에 있는지 구하고, 맨 마지막층의 해당 위치에 답이 있는지 구하면 된다.
// 최대 높이 - 자기 자신의 높이 + 마지막칸의 자신 위치에 상자가 있는지
public class Solution {
    public int solution(int n, int w, int num) {
        int answer = 0;
        int height = (int)Math.Ceiling((float)n/w) - 1;
        int numPosY = (int)Math.Ceiling((float)num/w) - 1;
        int numPosX = 0;
        int lastFloorCnt = (n-1) % w;
        
        
        numPosX = numPosY % 2==0 ? (num-1) % w : (w-1) - (num-1) % w;
        
        bool haveInLastFloor = height % 2==0 ? numPosX <= lastFloorCnt : w-1 - numPosX <= lastFloorCnt;
        
        answer = height - numPosY + (haveInLastFloor ? 1 : 0);
        
        if(height == numPosY)
            answer = 1;
        
        return answer;
    }
}