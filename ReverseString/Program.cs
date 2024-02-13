internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.Write("Please enter the expression: ");
        string expression = Console.ReadLine();

        string reverseExpression = "";

        for(int i = expression.Length - 1; i >= 0; i--){
            
            reverseExpression += expression[i];

        }

        Console.WriteLine(reverseExpression);
    }
}