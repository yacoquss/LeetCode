namespace TestApp._657._Robot_Return_to_Origin;

public class Program
{
    
}

public class Solution {
    public bool JudgeCircle(string moves)
    {
        int Xpos = 0, Ypos = 0;
        foreach (var c in moves)
        {
            if (c == 'L') Xpos--;
            if (c == 'R') Xpos++;
            if (c == 'U') Ypos--;
            if (c == 'D') Ypos++;
        }

        if (Xpos == 0 && Ypos == 0) return true;
        else return false;
        
    }
}