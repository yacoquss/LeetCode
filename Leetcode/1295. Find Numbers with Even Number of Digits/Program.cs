namespace TestApp._1295._Find_Numbers_with_Even_Number_of_Digits;

public class Program
{
    
}

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (CountNumbers(nums[i]) % 2 == 0)
            {
                sum++;
            }
        }

        return sum;
    }

    private int CountNumbers(int num)
    {
        return num.ToString().Length;
    }
}