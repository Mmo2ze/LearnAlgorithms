namespace Metwally;

public class Correlation
{
    public List<double> xs { get; set; }
    public List<double> ys { get; set; }

    public double GetCorrelation()
    {
        var xSum = xs.Sum();
        var ySum = ys.Sum();
        var n = xs.Count;
        var a = GetA();
        var b = xSum * ySum;
        var c = GetC(xSum, n);
        var d = GetD(ySum, n);
        var up = a - b;
        var down = c * d;
        return up / down;
    }

    private double GetD(double ySum, int n)
    {
        var a = n * ys.Sum(n => Math.Pow(n, 2));

        var b = Math.Pow(ySum, 2);

        return Math.Sqrt(a - b);
    }

    private double GetC(double xSum, int n)
    {
        var a = n * xs.Sum(n => Math.Pow(n, 2));

        var b = Math.Pow(xSum, 2);

        return Math.Sqrt(a - b);
    }


    private double GetA()
    {
        var n = xs.Count;
        double a = 0;
        for (var i = 0; i < n; i++)
        {
            a += xs[i] * ys[i];
        }

        return a*n;
    }
}