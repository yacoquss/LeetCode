namespace TestApp._412._Fizz_Buzz;

public class Program
{
    
}

public class Solution {
    public IList<string> FizzBuzz(int n)
    {
        IList<string> result = new List<string>();
        while (n > 0)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                result.Add("FizzBuzz");
            }
            else if (n % 3 == 0)
            {
                result.Add("Fizz");
            }
            else if (n % 5 == 0)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add(n.ToString());
            }
            n--;
        }
        var reversed = result.Reverse().ToList();
        return reversed;
    }
}