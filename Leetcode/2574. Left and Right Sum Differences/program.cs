namespace TestApp._2574._Left_and_Right_Sum_Differences;

public class program
{
    public class Solution {
        public int[] LeftRightDifference(int[] nums) {
            int[] result = new int[nums.Length], leftSumArr = new int[nums.Length], rightSumArr = new int[nums.Length];
            int leftSum = 0, rightSum = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                leftSumArr[j] = leftSum;
                leftSum += nums[j];

                rightSumArr[nums.Length - 1 - j] = rightSum;
                rightSum += nums[nums.Length - 1 - j];
            }

            for (int i = 0; i < nums.Length; i++)
                result[i] = Math.Abs(leftSumArr[i] - rightSumArr[i]);

            return result;
        }
    }
}