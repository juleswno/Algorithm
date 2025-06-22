using System; // C#에서 기본 기능을 사용하기 위해 필요한 코드야

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0; // 정답을 저장할 변수, 처음엔 0으로 시작해

        string target = k.ToString(); // 찾고 싶은 숫자 k를 글자로 바꿔 (예: 1 → "1")

        // i부터 j까지 하나씩 숫자를 살펴볼 거야
        for (int num = i; num <= j; num++) {
            string str = num.ToString(); // 지금 숫자를 글자로 바꿔 (예: 12 → "12")

            // 글자로 바꾼 숫자에서 한 글자씩 꺼내볼 거야
            foreach (char c in str) {
                // 글자 하나가 우리가 찾는 글자인지 확인해
                if (c.ToString() == target) {
                    answer++; // 찾았다! 정답에 1을 더해
                }
            }
        }

        return answer; // 다 끝났으면 정답을 돌려줘
    }
}