//https://leetcode.com/submissions/detail/477488669/
//https://leetcode.com/problems/reverse-integer/
class Solution {
public:
    int reverse(int x) 
    {
        long result = 0;
        
        string s = to_string(x);
        
        string temp = "";
        for(int i = s.size() - 1; i >= 0; --i)
        {
            temp += s[i];
        }
        
        result = stol(temp);
        
        if(result > INT_MAX)
            return 0;
        if(x < 0)
        return -(int)result;
        else
            return (int)result;
    }
};
