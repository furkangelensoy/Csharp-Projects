using System.Diagnostics;

namespace DualSum{
    public class Program
{
        private static void Main(string[] args)
        {
           Sum sum = new Sum();
           Console.Write("Enter the count of numbers: ");
           sum.TakeNumbers(int.Parse(Console.ReadLine()));
        }
    }
}
