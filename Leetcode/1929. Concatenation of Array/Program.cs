namespace TestApp._1929._Concatenation_of_Array;

public class Program
{
    public int[] GetConcatenation(int[] nums) => nums.Concat(nums).ToArray();
}