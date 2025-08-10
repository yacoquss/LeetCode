namespace TestApp._2469._Convert_the_Temperature;

public class Program
{
    public double[] ConvertTemperature(double celsius)
    {
        return new double[] { celsius + 273.15, celsius * 1.80 + 32.00 };
    }
}