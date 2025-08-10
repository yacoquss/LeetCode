using System.Text;

namespace TestApp._3110._Score_of_a_String;

public class Program
{
    public int ScoreOfString(string s)
    {
        byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
        int sum = 0;
        for (int i = 0; i < asciiBytes.Length - 1; i++)
        {
            sum += Math.Abs(asciiBytes[i] - asciiBytes[i + 1]);
        }

        return sum;
    }
}