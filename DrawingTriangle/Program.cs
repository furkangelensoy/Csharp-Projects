
namespace DrawingTriangle{
    public class Program
{
    private static void Main(string[] args)
    {
        int height;

        Console.Write("Please enther the height of the triangle: ");
        height = int.Parse(Console.ReadLine());

        for(int i = 1; i <= height; i++){
            for(int j = height - i; j > 0; j--){
                Console.Write(" ");
            }
            for(int k = 1; k <= (2*i) - 1; k++){
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
}
