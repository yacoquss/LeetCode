namespace TestApp._2206._Divide_Array_Into_Equal_Pairs;


    

    public class Solution
    {
        public bool DivideArray(int[] nums)
        {
            var pairsCount = nums.Length / 2;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i+=2)
            {
                if (nums[i] != nums[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
