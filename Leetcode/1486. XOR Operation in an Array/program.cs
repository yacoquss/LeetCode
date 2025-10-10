namespace TestApp._1486._XOR_Operation_in_an_Array;

public class program
{
    public int XorOperation(int n, int start)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            list.Add(i * 2 + start);
        }
        return list.Aggregate(0, (acc, num) => acc ^ num);
    }
}