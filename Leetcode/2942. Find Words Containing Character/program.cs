namespace TestApp._2942._Find_Words_Containing_Character;

public class program
{
    
}
public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        IList<int> result = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))
            {
                result.Add(i);
            }
        }
        return result;
    }
}