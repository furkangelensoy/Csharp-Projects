
internal class Program
{
    private static void Main(string[] args)
    {
        double radius, thickness = 0.3;

        Console.Write("Please enter the radius of circle: ");
        radius = int.Parse(Console.ReadLine());

        double inSide = radius - thickness, outSide = radius + thickness;

        for(double i = radius; i >= -radius; i--){
            for(double j = -radius; j < outSide; j += 0.5){
                
                double value = Math.Pow(i,2) + Math.Pow(j,2);
                if(value >= Math.Pow(inSide,2) && value <= Math.Pow(outSide,2)){
                    Console.Write("*");
                }else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        } 
    }
}