namespace Metwally;

public class StandardDeviation
{
    private List<double> Numbers { get; set; }


    public StandardDeviation(List<double> numbers)
    {
        Numbers = numbers;
    }

    public double GetStandardDeviation()
    {
        var mean = Numbers.Average();
        
        var bSum = Numbers.Sum(number => Math.Pow(number - mean, 2));

        return Math.Sqrt(bSum / Numbers.Count);
    }      
    
}