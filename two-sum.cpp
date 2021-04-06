//https://leetcode.com/submissions/detail/477035166/
//https://leetcode.com/problems/two-sum/

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) 
    {
        vector<int> result(2);
        
        for(int i = 0; i < nums.size(); ++i)
        {
            for(int j = i+1; j < nums.size(); ++j)
            {
                const auto temp = nums[i] + nums[j];
                if(temp == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        
        return result;
    }
};
