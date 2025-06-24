namespace TestApp._2200._Find_All_K_Distant_Indices_in_an_Array;

public class Program
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var result = new List<int>();
        var keyIndices = new List<int>();

        
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] == key)
            {
                keyIndices.Add(j);
            }
        }

        
        for (int i = 0; i < nums.Length; i++)
        {
            foreach (int j in keyIndices)
            {
                if (Math.Abs(i - j) <= k)
                {
                    result.Add(i);
                    break; 
                }
            }
        }

        
        return result;
    }
}