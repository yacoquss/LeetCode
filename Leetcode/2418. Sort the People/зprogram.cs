namespace TestApp._2418._Sort_the_People;

public class зprogram
{
    public string[] SortPeople(string[] names, int[] heights) {
        
        return names
            .Select((name, index) => (name, height: heights[index]))
            .OrderByDescending(x => x.height)
            .Select(x => x.name)
            .ToArray();
    }
}