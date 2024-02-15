namespace AreaCalculator{
    public class Rectangle{
        public double shortEdge;
        public double longEdge;

        public Rectangle(double shortEdge, double longEdge){
            shortEdge = this.shortEdge;
            longEdge = this.longEdge;
        }

        public double Perimeter(double shortEdge, double longEdge){
            return (2*shortEdge) + (2 * longEdge);
        }

        public double Area(double shortEdge, double longEdge){
            return shortEdge*longEdge;
        }
    }
}