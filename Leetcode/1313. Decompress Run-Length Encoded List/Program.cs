namespace TestApp._1313._Decompress_Run_Length_Encoded_List;

public class Program
{
    
}

public class Solution {
    public int[] DecompressRLElist(int[] nums)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i += 2)
        {
            int[] generated = GenerateNums(nums[i], nums[i + 1]);
            result.AddRange(generated);
        }
        return result.ToArray();
    }

    private int[] GenerateNums(int freq, int val)
    {
        int[] nums = new int[freq];
        for (int i = 0; i < freq; i++)
        {
            nums[i] = val;
        }
        return nums;
    }
}
