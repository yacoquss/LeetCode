namespace TestApp._2176._Count_Equal_and_Divisible_Pairs_in_an_Array;

public class Program
{
    public class Solution {
        public int CountPairs(int[] nums, int k)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (0 <= i & nums[i] == nums[j] & i < j & j < nums.Length)
                    {
                        if (i*j % k == 0)
                        {
                            count++;
                        }
                    
                    }
                }
            }
            return count;
        }
    }
}