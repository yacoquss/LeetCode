namespace TestApp.Merge_Two_2D_Arrays_by_Summing_Values;

public class Program
{
    public class Solution {
   
        public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        
            int i = 0, j = 0;
        
            List<int[]> resultList = new List<int[]>();
        
        
            while (i < nums1.Length && j < nums2.Length) {
                int id1 = nums1[i][0], val1 = nums1[i][1];
                int id2 = nums2[j][0], val2 = nums2[j][1];
            
                if (id1 < id2) {
                
                    resultList.Add(new int[] {id1, val1});
                    i++;
                } else if (id2 < id1) {
                
                    resultList.Add(new int[] {id2, val2});
                    j++;
                } else {
                
                    resultList.Add(new int[] {id1, val1 + val2});
                    i++;
                    j++;
                }
            }
        
        
            while (i < nums1.Length) {
                resultList.Add(nums1[i]);
                i++;
            }
        
        
            while (j < nums2.Length) {
                resultList.Add(nums2[j]);
                j++;
            }
        
            return resultList.ToArray();
        }
    }

}