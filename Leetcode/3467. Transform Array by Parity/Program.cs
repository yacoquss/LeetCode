namespace TestApp._3467._Transform_Array_by_Parity;

public class Program
{
    public class Solution {
        public int[] TransformArray(int[] nums) {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums[i] = 0;
                }
                else
                {
                    nums[i] = 1;
                }
            }

            Array.Sort(nums);
            return nums;
        }
    }
}