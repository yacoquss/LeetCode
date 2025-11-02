namespace TestApp._2778._Sum_of_Squares_of_Special_Elements;

public class Solution {
    public int SumOfSquares(int[] nums) {
        int sum = 0;
        int n = nums.Length;
        
        for (int i = 0; i < n; i++) {
            
            if (n % (i + 1) == 0) {
                sum += nums[i] * nums[i];
            }
        }
        
        return sum;
    }
}