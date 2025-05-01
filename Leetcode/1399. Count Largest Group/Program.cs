namespace TestApp._1399._Count_Largest_Group;

public class Program
{
    
}

public class Solution {
    public int CountLargestGroup(int n)
    {
        Dictionary<int, int> countSums = new();
        int max = 0;
        for (int i = 1; i <= n; i++)
        {
            int sum = SumOfDigits(i);
            if (countSums.ContainsKey(sum))
                countSums[sum] = countSums[sum] + 1;
            else
                countSums[sum] = 1;

            max = Math.Max(max, countSums[sum]);
        }


        int count = 0;
        foreach (int sum in countSums.Values)
        {
            if (max == sum)
            {
                count++;
            }
        }

        return count;
    }

    private int SumOfDigits(int n)
    {
        return n.ToString().ToCharArray().Sum(c => c - '0');
    }
}