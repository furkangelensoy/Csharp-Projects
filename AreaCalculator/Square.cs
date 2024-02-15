namespace AreaCalculator{

    public class Square{
        public double edge;

        public Square(double edge){
            edge = this.edge;
        }

        public double Perimeter(double edge){

            return edge*4;
        }

        public double Area(double edge){
            return Math.Pow(edge,2);
        }
    }
    
}