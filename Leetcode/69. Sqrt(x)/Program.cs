namespace TestApp._69._Sqrt_x_;

public class Program
{
}

public class Solution
{
    public int MySqrt(int x) {
        if (x == 0) return 0;
        
        double epsilon = 1e-6;
        double result = x; 
        double prev;
        
        do {
            prev = result;
            result = (result + x / result) / 2;
        } while (Math.Abs(prev - result) > epsilon);
        
        return (int)result;
    }
}