namespace TestApp._2956._Find_Common_Elements_Between_Two_Arrays;

public class program
{
    
}

public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        List<int> result = new List<int>();
        int first_answer = 0;
        int second_answer = 0;
        foreach (var num in nums1)
        {
            if(nums2.Contains(num)) first_answer++;
        }
        foreach (var num in nums2)
        {
            if(nums1.Contains(num)) second_answer++;
        }
        result.Add(first_answer);
        result.Add(second_answer);
        return result.ToArray();
    }
}