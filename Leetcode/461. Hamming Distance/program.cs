namespace TestApp._461._Hamming_Distance;

public class Solution {
    public int HammingDistance(int x, int y)
    {
        string binary_x = ConvertToBinary(x).PadRight(32, '0');
        string binary_y = ConvertToBinary(y).PadRight(32, '0');
    
        int dis = 0;
        int minLength = Math.Min(binary_x.Length, binary_y.Length);
    
        for (int i = 0; i < minLength; i++)
        {
            if (binary_x[i] != binary_y[i])
                dis++;
        }
    
        return dis;
    }
    private string ConvertToBinary(int s)
    {
        string binary = "";
        while (s > 0)
        {
            binary += s % 2;
            s /= 2;
        }
        return binary;
    }
}