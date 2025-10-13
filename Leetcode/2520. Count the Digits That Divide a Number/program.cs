namespace TestApp._2520._Count_the_Digits_That_Divide_a_Number;

public class program
{
    public class Solution {
        public int CountDigits(int num) {
            int count = 0;
            int temp = num;
        
            
            while (temp > 0) {
                int digit = temp % 10;  
                if (digit != 0 && num % digit == 0) {
                    count++;
                }
                temp /= 10;  
            }
        
            return count;
        }
    }
}