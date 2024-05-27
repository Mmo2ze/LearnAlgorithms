using Metwally;

var xNumbers = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var yNumbers = new List<double> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
var correlation = new Correlation { xs = xNumbers, ys = yNumbers };
var result = correlation.GetCorrelation();
Console.WriteLine($"Correlation: {result}");
