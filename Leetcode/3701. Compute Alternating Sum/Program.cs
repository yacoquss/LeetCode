namespace TestApp._3701._Compute_Alternating_Sum;

public class Program
{
    public int AlternatingSum(int[] nums)
    {
        int evenSum = 0;
        int oddSum = 0;
    
        // Сумма четных индексов
        for (int i = 0; i < nums.Length; i += 2)
        {
            evenSum += nums[i];
        }
    
        // Сумма нечетных индексов
        for (int i = 1; i < nums.Length; i += 2)
        {
            oddSum += nums[i];
        }
    
        return evenSum - oddSum;
    }
}