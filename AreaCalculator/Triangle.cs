namespace AreaCalculator{
    public class Triangle{
        public double edge1;
        public double edge2;
        public double edge3;

        public Triangle(double edge1, double edge2, double edge3){
            edge1 = this.edge1;
            edge2 = this.edge2;
            edge3 = this.edge3;
        }

        public double Perimeter(double edge1, double edge2, double edge3){
            return edge1 + edge2 + edge3;
        }

        public double Area(double edge1, double edge2, double edge3){
            double s = Perimeter(edge1,edge2,edge3)/2;
            return Math.Sqrt(s*(s-edge1)*(s-edge2)*(s-edge3));
        }
    }
}