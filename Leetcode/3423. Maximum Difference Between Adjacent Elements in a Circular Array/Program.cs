namespace TestApp._3423._Maximum_Difference_Between_Adjacent_Elements_in_a_Circular_Array;

public class Program
{
    public int MaxAdjacentDistance(int[] nums) {
        if (nums == null || nums.Length < 2) {
            return 0;
        }
        
        int maxDiff = 0;
        int n = nums.Length;
        
        for (int i = 0; i < n; i++) {
            int nextIndex = (i + 1) % n; 
            int currentDiff = Math.Abs(nums[i] - nums[nextIndex]);
            if (currentDiff > maxDiff) {
                maxDiff = currentDiff;
            }
        }
        
        return maxDiff;
    }
}