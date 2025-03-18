namespace TestApp._1281._Subtract_the_Product_and_Sum_of_Digits_of_an_Integer;

public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        return ProductOfDigits(n) - SumOfDigits(n);
    }

    private int ProductOfDigits(int num)
    {
        int[] digit = new int[num.ToString().Length];
        int product = 1;

        for (int i = 0; i < digit.Length; i++)
        {
            digit[i] = num % 10;
            num /= 10;
        }

        foreach (var i in digit)
        {
            product *= i;
        }

        return product;
    }

    private int SumOfDigits(int num)
    {
        int[] digit = new int[num.ToString().Length];

        for (int i = 0; i < digit.Length; i++)
        {
            digit[i] = num % 10;
            num /= 10;
        }

        return digit.Sum();
    }
}