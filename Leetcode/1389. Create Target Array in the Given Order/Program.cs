namespace TestApp._1389._Create_Target_Array_in_the_Given_Order;

public class Program
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        var list = new List<int>(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            list.Insert(index[i], nums[i]);
        }
        return list.ToArray();
    }
}

