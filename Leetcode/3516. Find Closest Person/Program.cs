namespace TestApp._3516._Find_Closest_Person;

public class Program
{
    public int FindClosest(int x, int y, int z) {
        int dx = Math.Abs(z - x), dy = Math.Abs(z - y);
        return dx == dy ? 0 : dx < dy ? 1 : 2;
    }
}