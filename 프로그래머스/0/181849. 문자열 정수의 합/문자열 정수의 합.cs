using System;

public class Solution {
    public int solution(string num_str) {
        
        int answer = 0;
        
        foreach(char cha in num_str)
        {
            answer += int.Parse(cha.ToString());
        }
        
        return answer;
    }
}