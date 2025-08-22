//구명보트에 사람을 무게 제한에 맞게 채워서 최소한의 횟수로 구명보트를 이용해야한다.
//배열을 돌다보면 이미 탔던 사람이 있을 수 있으니 같은 크기의 벡터를 하나 만들어준다.
//구명보트는 최대로 태울 수 있는 인원은 2명이다.
/* 수정 전
#include <string>
#include <vector>

using namespace std;

int solution(vector<int> people, int limit) {
    int answer = 0;
    int sumWeight = 0;
    int count = 0;
    vector<bool> isride;
    
    for(int i = 0; i<people.size(); i++)
    {
        isride.push_back(false);
    }
    for(int i = 0; i<people.size(); i++)
    {
        if(isride[i] == true)
        {
            continue;
        }
        for(int j = i; j<people.size(); j++)
        {
            if(isride[j] == false && sumWeight + people[j] <= 100)
            {
                count++;
                sumWeight += people[j];
                isride[j] = true;
                if(count>=2)
                    break;
            }
        }
        count = 0;
        answer++;
        sumWeight = 0;
    }
    return answer;
}
*/
//-------------------------------------------------------------------------
// 내가 생각한 대로는 동작이 되지 않아, 다른 사람의 문제 풀이를 확인하였다.
// 정렬을 먼저 하고 시작하면 더 쉽고 효율적인 것을 알게 되었다.
// 투 포인터를 이용하여 처음과 끝을 지정하고,
// 가장 가벼운 사람과 무거운 사람을 확인한다.
// 가장 가벼운 사람과 무거운 사람의 값을 더했을 때, 무게 제한을 넘으면 무거운 사람만 보낸다.
// 그 다음 무거운 사람과 가벼운 사람을 비교하며 반복한다.
#include <algorithm>
#include <vector>

using namespace std;

int solution(vector<int> people, int limit) {
    int answer = 0;
    int sumWeight = 0;
    int count = 0;
    
    sort(people.begin(), people.end());
    
    int start = 0;
    int end = people.size() - 1;
    
    while(start <= end)
    {
        if(people[start] + people[end] <= limit)
        {
            end--;
            start++;
        }
        else
        {
            end--;
        }
        answer++;
    }
    
    return answer;
}