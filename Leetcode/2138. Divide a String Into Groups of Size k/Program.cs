namespace TestApp._2138._Divide_a_String_Into_Groups_of_Size_k;

public class Program
{
    public string[] DivideString(string s, int k, char fill)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < s.Length; i += k)
        {
            int length = Math.Min(k, s.Length - i);
            string group = s.Substring(i, length);
            if (group.Length < k)
            {
                group += new string(fill, k - group.Length);
            }
            result.Add(group);
        }
        return result.ToArray();
    }
}