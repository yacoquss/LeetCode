namespace TestApp._771._Jewels_and_Stones;

public class Program
{
    
}

public class Solution {
    public int NumJewelsInStones(string jewels, string stones)
    {
        int count = 0;
        for (var i = 0; i < stones.Length; i++)
        {
            if (jewels.Contains(stones[i]))
            {
                count++;
            }
        }

        return count;
    }
}