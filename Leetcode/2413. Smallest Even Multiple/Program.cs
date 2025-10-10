namespace TestApp._2413._Smallest_Even_Multiple;

public class Program
{
    public int SmallestEvenMultiple(int n)
    {
        if (n % 2 == 0) return n;
        else return (n * 2);
    }
}