namespace TestApp._2011._Final_Value_of_Variable_After_Performing_Operations;

public class Program
{
    
}
public class Solution {
    public int FinalValueAfterOperations(string[] operations)
    {
        int x = 0;
        
        foreach (var operation in operations)
        {
            if(operation == "X++" || operation == "++X"){
                ++x;
            } else{
                --x;
            }
        }
        return x;
    }
}