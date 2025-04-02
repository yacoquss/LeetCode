namespace TestApp._1200._Minimum_Absolute_Difference;

public class Program
{
    
}
public class Solution
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        IList<int> list = new List<int>();
        List<int> minlist = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(arr);
        for (int _ = 0; _ < arr.Length - 1; _++)
        {
            minlist.Add(arr[_ + 1] - arr[_]);
        }

        int min = Enumerable.Min(minlist);
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] - arr[i] == min)
            {
                list.Add(arr[i]);
                list.Add(arr[i + 1]);
            }

            if (list.Count != 0)
            {
                result.Add(new List<int>(list));
            }

            list.Clear();
        }


        return result;
    }
}