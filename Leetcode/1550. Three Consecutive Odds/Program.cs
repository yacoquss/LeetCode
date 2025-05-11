namespace TestApp._1550._Three_Consecutive_Odds;

public class Program
{
    
}
public class Solution
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        for (int i = 0; i <= arr.Length - 3; i++)
        {
            if (IsOdd(arr[i]) & IsOdd(arr[i + 1]) & IsOdd(arr[i + 2]))
            {
                return true;
            }
        }
        return false;
    }

    private bool IsOdd(int num)
    {
        return num % 2 != 0;
    }
}