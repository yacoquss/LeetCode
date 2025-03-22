namespace TestApp._1309._Decrypt_String_from_Alphabet_to_Integer_Mapping;



public class Solution
{
    public string FreqAlphabets(string s)
    {
        List<char> result = new List<char>();
        int i = s.Length - 1;

        while (i >= 0)
        {
            if (s[i] == '#')
            {

                int num = int.Parse(s.Substring(i - 2, 2));
                char c = (char)(num - 10 + 'j');
                result.Add(c);
                i -= 3;
            }
            else
            {

                int num = s[i] - '0';
                char c = (char)(num - 1 + 'a');
                result.Add(c);
                i--;
            }
        }

        result.Reverse();
        return new string(result.ToArray());
    }
}