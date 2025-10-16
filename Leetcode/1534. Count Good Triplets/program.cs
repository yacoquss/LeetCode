namespace TestApp._1534._Count_Good_Triplets;

public class program
{
    public class Solution {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if ((0 <= i) & i < j & j < k & k < arr.Length)
                        {
                            if (Math.Abs(arr[i] - arr[j]) <= a)
                            {
                                if (Math.Abs(arr[j] - arr[k]) <= b)
                                {
                                    if (Math.Abs(arr[i] - arr[k]) <= c)
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}