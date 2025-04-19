namespace TestApp._1002._Find_Common_Characters;

public class Program
{
    
}

public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        var result = new List<string>();

        for (var i = 'a'; i <= 'z'; i++)
        {
            var count = words.Min(w => w.Count(c => c == i));

            while (--count >= 0)
                result.Add(i.ToString());
        }

        return result;
    }
}