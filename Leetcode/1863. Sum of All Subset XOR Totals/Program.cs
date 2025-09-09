namespace TestApp._1863._Sum_of_All_Subset_XOR_Totals;

public class Program
{
    
}

public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        int totalSum = 0;
        int n = nums.Length;


        for (int mask = 0; mask < (1 << n); mask++)
        {
            int xor = 0;


            for (int i = 0; i < n; i++)
            {
                if ((mask & (1 << i)) != 0)
                {
                    xor ^= nums[i];
                }
            }

            totalSum += xor;
        }

        return totalSum;
    }
}