namespace AreaCalculator{
    public class Circle{

        public double radius;
        
        public double pi = 3.14;
        public Circle(double radius){
            radius = this.radius;
        }

        public double Perimeter(double radius){
            return Math.PI*2*radius;
        }

        public double Area(double radius){
            return Math.PI*Math.Pow(radius,2);
        }


    }
}