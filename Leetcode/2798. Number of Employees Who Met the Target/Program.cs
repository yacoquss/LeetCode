namespace TestApp._2798._Number_of_Employees_Who_Met_the_Target;

public class Program
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        int count = 0;
        foreach (var hour in hours)
        {
            if(hour>=target)  count++;
        }
        return count;
    }
}