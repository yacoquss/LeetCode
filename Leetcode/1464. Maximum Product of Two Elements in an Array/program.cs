namespace TestApp._1464._Maximum_Product_of_Two_Elements_in_an_Array;

public class program
{
    public int MaxProduct(int[] nums)
    {
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                max = Math.Max(max, (nums[i] - 1) * (nums[j] - 1));
            }
        }

        return max;
    }
}