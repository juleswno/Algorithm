using System; 

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0; 

        string target = k.ToString(); // 찾고 싶은 숫자 k를 글자로 바꾸기

        // i부터 j까지 살펴보기
        for (int num = i; num <= j; num++) {
            string str = num.ToString(); // 글자로 바꾸기

            // 한 글자씩 꺼내보기
            foreach (char c in str) {
                // 글자 확인
                if (c.ToString() == target) {
                    answer++; 
                }
            }
        }

        return answer; 
    }
}
