namespace TestApp._1672._Richest_Customer_Wealth;

public class program
{
    public int MaximumWealth(int[][] accounts) {
        int result = 0;

        foreach (var acc in accounts)
        {
            result  = Math.Max(result, acc.Sum());
        }
        return result;
    }
}