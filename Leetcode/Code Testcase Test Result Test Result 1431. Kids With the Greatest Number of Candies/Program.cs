namespace TestApp.Code_Testcase_Test_Result_Test_Result_1431._Kids_With_the_Greatest_Number_of_Candies;

public class Program
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int greatest = candies.Max();
        return candies.Select(candy => candy + extraCandies >= greatest).ToList();
    }

}