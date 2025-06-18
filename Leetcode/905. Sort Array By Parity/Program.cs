namespace TestApp._905._Sort_Array_By_Parity;

public class Program
{
    public int[] SortArrayByParity(int[] nums) {
        List<int> odds = new List<int>();
        List<int> evens = new List<int>();
        foreach (var num in nums)
        {
            if(num % 2 == 0) odds.Add(num);
            else evens.Add(num);
        }
        
        return (odds.Concat(evens)).ToArray();
        
    }
}