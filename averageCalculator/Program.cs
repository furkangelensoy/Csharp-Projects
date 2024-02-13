namespace AverageCalculator{

    public class Program
{
    private static void Main(string[] args)
    {
        Fibonacci fibonacci = new Fibonacci();
        Calculate calculate = new Calculate();

        Console.Write("Please enter the depth of fibonacci: ");
        int depth = int.Parse(Console.ReadLine());

        Console.WriteLine("Average of the Fibonacci Series: " + calculate.Average(fibonacci.FibonacciSeries(depth)));
        
    }
}

}
