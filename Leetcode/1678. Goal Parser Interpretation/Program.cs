namespace TestApp._1678._Goal_Parser_Interpretation;

public class Program
{
    public string Interpret(string command)
    {
        return command.Replace("()", "o").Replace("(al)", "al");
    }
}