namespace TestApp._3289._The_Two_Sneaky_Numbers_of_Digitville;

public class Program
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        List<int> result = new List<int>();

        var counts = nums.GroupBy(n => n)
            .ToDictionary(g => g.Key, g => g.Count());
        foreach (var num in counts)
        {
            if(num.Value == 2) result.Add(num.Key);
        }

        return result.ToArray();
    }
}