//https://leetcode.com/problems/single-number-ii/
//https://leetcode.com/submissions/detail/480834890/
class Solution {
public:
    int singleNumber(vector<int>& nums) 
    {
        int result = 0;
        
        map<int, int> list;
        
        for(int i = 0; i < nums.size(); ++i)
        {
            const int num = nums[i];
            list[num] += 1;
        }
        
        for(auto temp : list)
        {
            if(temp.second == 1)
                return temp.first;
        }
        
        return result;
    }
};
