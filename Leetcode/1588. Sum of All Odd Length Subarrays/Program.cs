namespace TestApp._1588._Sum_of_All_Odd_Length_Subarrays;

public class Program
{
    public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int count = arr.Length;
        int result = 0;
        for(int i = 0; i < arr.Length; i ++)
        {
            int j = (i + 1)*(count - i)/2;
            if((i + 1)*(count - i)%2 != 0) j+=1;
            result += arr[i] * j;
        }
        
        return result;
    }
}
}