namespace TestApp._2733._Neither_Minimum_nor_Maximum;

public class program
{
    public class Solution {
        public int FindNonMinOrMax(int[] nums) {
            if (nums.Length < 3) return -1;
        
            Array.Sort(nums);
            return nums[1]; 
        }
    }
}