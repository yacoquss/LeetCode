namespace TestApp._1684._Count_the_Number_of_Consistent_Strings;

public class Program
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        return words.Count(word => word.All(c => allowed.Contains(c)));
    }
}