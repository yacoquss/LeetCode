namespace TestApp._1323._Maximum_69_Number;

public class Program
{
    public int Maximum69Number(int num)
    {
        var s = num.ToString().ToCharArray();
        char six = Convert.ToChar('9');
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '6')
            {
                s[i] = six;

                return Convert.ToInt32(new string(s));
            }
        }

        return num;
    }
}