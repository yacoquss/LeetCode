namespace TestApp._3151._Special_Array_I;

public class program
{
    public class Solution {
        public bool IsArraySpecial(int[] nums) {
            if (nums.Length == 1) return true;
        
            for (int i = 0; i < nums.Length - 1; i++) {
                // Check if adjacent elements have the same parity
                if (nums[i] % 2 == nums[i + 1] % 2) {
                    return false;
                }
            }
            return true;
        }
    }
}