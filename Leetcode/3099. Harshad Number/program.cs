namespace TestApp._3099._Harshad_Number;

public class program
{
    public class Solution {
        public int SumOfTheDigitsOfHarshadNumber(int x)
        {
            var sum = SumOfDigits(x);
            if (x % sum == 0 && x % sum == 0) return sum;

            return -1;
        }

        int SumOfDigits(int x)
        {
            int result = 0;
            while (x > 0)
            {
                result +=  x % 10;
                x /= 10;
            }
            return result;
        }
    }
}