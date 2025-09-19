namespace TestApp._3541._Find_Most_Frequent_Vowel_and_Consonant;

public class Program
{
    public class Solution
    {
        List<string> vowels = new List<string>()
        {
            "a", "e", "i", "o", "u"
        };

        public int MaxFreqSum(string s)
        {
            var vowelCounts = s.Select(c => c)
                .Where(t => vowels.Contains(t.ToString()))
                .GroupBy(c => c)
                .Select(g => new { Letter = g.Key, Count = g.Count() })
                .ToList();

            var consonantCounts = s.Select(c => c)
                .Where(t => !vowels.Contains(t.ToString()))
                .GroupBy(c => c)
                .Select(g => new { Letter = g.Key, Count = g.Count() })
                .ToList();

            
            int maxVowel = vowelCounts.Any() ? vowelCounts.Max(x => x.Count) : 0;
        
            
            int maxConsonant = consonantCounts.Any() ? consonantCounts.Max(x => x.Count) : 0;

            return maxVowel + maxConsonant;
        }
    }
}