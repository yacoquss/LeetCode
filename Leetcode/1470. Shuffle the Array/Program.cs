namespace TestApp._1470._Shuffle_the_Array;

public class Program
{
    public int[] Shuffle(int[] nums, int n) {
        List<int> result = new List<int>();
    
        for (int i = 0; i < n; i++) {
            result.Add(nums[i]);        
            result.Add(nums[i + n]);    
        }
    
        return result.ToArray();
    }
}