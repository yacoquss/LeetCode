namespace TestApp._2099._Find_Subsequence_of_Length_K_With_the_Largest_Sum;

public class program
{
    public int[] MaxSubsequence(int[] nums, int k) {
      
        var indexedNums = nums.Select((num, index) => (num, index)).ToArray();
        Array.Sort(indexedNums, (a, b) => b.num.CompareTo(a.num)); 
    
        var topK = indexedNums.Take(k).OrderBy(x => x.index).ToArray();
    
        return topK.Select(x => x.num).ToArray();
    }
}