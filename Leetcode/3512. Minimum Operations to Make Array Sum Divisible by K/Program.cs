namespace TestApp._3512._Minimum_Operations_to_Make_Array_Sum_Divisible_by_K;

public class Program
{
    public int MinOperations(int[] nums, int k)
    {
        
        long totalSum = 0;
        foreach (var num in nums) totalSum += num;
    
        if (totalSum % k == 0) return 0;
    
        int remainder = (int)(totalSum % k);
        int result = remainder; 
    
        
        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            long testSum = totalSum;
        
            
            while (nums[i] - count > 0 && testSum % k != 0)
            {
                count++;
                testSum--;
            
                if (testSum % k == 0)
                {
                    result = Math.Min(result, count);
                    break;
                }
            }
        }
    
        return result;
    }
}