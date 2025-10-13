namespace TestApp._2824._Count_Pairs_Whose_Sum_is_Less_than_Target;

public class Program
{
    public class Solution
    {
        public int CountPairs(IList<int> nums, int target)
        {
            int count = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (i < j)
                    {
                        if (nums[i] + nums[j] < target)
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