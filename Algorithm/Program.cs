internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Please enter a text and number like with ',' ; (this,2): ");
        string expression = Console.ReadLine();

        string[] split = expression.Split(',');

        string first = split[0];
        int second = int.Parse(split[1]);
        string newExpression = first.Remove(second,1);
        Console.WriteLine(newExpression);
    }
}