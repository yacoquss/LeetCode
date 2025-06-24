namespace TestApp._2200._Find_All_K_Distant_Indices_in_an_Array;

public class Program
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var result = new List<int>();
        var keyIndices = new List<int>();

        // 1. Находим все индексы, где nums[j] == key
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] == key)
            {
                keyIndices.Add(j);
            }
        }

        // 2. Для каждого индекса i проверяем, есть ли j, такой что |i - j| <= k
        for (int i = 0; i < nums.Length; i++)
        {
            foreach (int j in keyIndices)
            {
                if (Math.Abs(i - j) <= k)
                {
                    result.Add(i);
                    break; // Достаточно одного совпадения
                }
            }
        }

        // 3. Ответ уже отсортирован, так как мы перебираем i по порядку
        return result;
    }
}