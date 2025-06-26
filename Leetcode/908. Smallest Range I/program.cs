namespace TestApp._908._Smallest_Range_I;

public class program
{
    public int SmallestRangeI(int[] nums, int k) 
    {
        int min_original = nums.Min();
        int max_original = nums.Max();
    
        if (max_original - min_original <= 2 * k)
        {
            return 0;
        }
        else
        {
            return (max_original - k) - (min_original + k);
        }
    }
}