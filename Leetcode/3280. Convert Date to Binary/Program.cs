namespace TestApp._3280._Convert_Date_to_Binary;

public class Program
{
    public class Solution {
        public string ConvertDateToBinary(string date) {
            _ = DateTime.TryParseExact(date, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out var dt);
            return Convert.ToString(dt.Year, 2) + "-" + Convert.ToString(dt.Month, 2) + "-" + Convert.ToString(dt.Day, 2);
        }
    }
}