namespace TestApp._1480._Running_Sum_of_1d_Array;

public class program
{
    public class Solution {
        public int[] RunningSum(int[] nums) {
            for (int i = 1; i < nums.Length; i++) {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}