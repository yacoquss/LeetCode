namespace TestApp._2894._Divisible_and_Non_divisible_Sums_Difference;

public class Program
{
    public int DifferenceOfSums(int n, int m)
    {
        int sumDivisible = 0;
        int sumNotDivisible = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % m == 0)
            {
                sumDivisible += i;
            }
            else
            {
                sumNotDivisible += i;
            }
        }

        return sumNotDivisible - sumDivisible;
    }
}