namespace TestApp._2006._Count_Number_of_Pairs_With_Absolute_Difference_K;

public class Solution {
    public int CountKDifference(int[] nums, int k)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if(i<j & Math.Abs(nums[i] - nums[j]) == k)
                {
                    count++;
                }
            }
        }
        
        return count;
    }
}