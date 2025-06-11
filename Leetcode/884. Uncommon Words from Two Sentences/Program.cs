namespace TestApp._884._Uncommon_Words_from_Two_Sentences;

public class Program
{
    public string[] UncommonFromSentences(string s1, string s2) 
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
    
        // Подсчитываем все слова из первого предложения
        foreach (string word in s1.Split())
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }
    
        // Подсчитываем все слова из второго предложения
        foreach (string word in s2.Split())
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }
    
        // Выбираем слова, которые встречаются ровно один раз
        return wordCount.Where(pair => pair.Value == 1)
            .Select(pair => pair.Key)
            .ToArray();
    }
}
