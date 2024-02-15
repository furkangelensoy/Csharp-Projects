namespace AbsoluteSquare{
    public class Program
{
    private static void Main(string[] args)
    {
        TakeNumbers takeNumbers = new TakeNumbers();
        Console.Write("Enter the count of numbers: ");
        int[] numbers = takeNumbers.Numbers(int.Parse(Console.ReadLine()));
        takeNumbers.Calculate(numbers);

    }
}
}
