using System.Text;

namespace TestApp._3174._Clear_Digits;

public class program
{
    public class Solution {
        public string ClearDigits(string s) {
            StringBuilder result = new StringBuilder();
        
            foreach (char c in s) {
                if (char.IsDigit(c)) {
                
                    if (result.Length > 0) {
                        result.Length--; 
                    }
                } else {
                
                    result.Append(c);
                }
            }
        
            return result.ToString();
        }
    }
}