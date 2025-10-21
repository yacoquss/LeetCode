namespace TestApp._2053._Kth_Distinct_String_in_an_Array;

public class program
{
    public class Solution {
        public string KthDistinct(string[] arr, int k) {
        
            Dictionary<string, int> count = new Dictionary<string, int>();
        
        
            foreach (string s in arr) {
                if (count.ContainsKey(s)) {
                    count[s]++;
                } else {
                    count[s] = 1;
                }
            }
        
        
            int distinctCount = 0;
            foreach (string s in arr) {
                if (count[s] == 1) {  
                    distinctCount++;
                    if (distinctCount == k) {
                        return s;  
                    }
                }
            }
        
        
            return "";
        }
    }
}