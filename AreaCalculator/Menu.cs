namespace AreaCalculator{
    public class Menu{

        public void ChooseShape(){
            

            Console.WriteLine("1- Circle\n" + "2- Rectangle\n" + "3- Square\n" + "4- Triangle\n" + "5- Exit");

            Console.Write("Chose your geometric shape: ");
            
            int choose = int.Parse(Console.ReadLine());

            switch(choose){
                case 1:
                    Console.Write("Enter a radius value: ");
                    double radius = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    int f = ChooseCalculator();            
                    if(f == 1){
                        Console.WriteLine("\t\t ******* \t\t");
                        Console.WriteLine("Circle's Perimeter: " + circle.Perimeter(radius));
                        Console.WriteLine("\t\t ******* \t\t");
                        ChooseShape();
                    }else if(f == 2){
                        Console.WriteLine("\t\t ******* \t\t");
                        Console.WriteLine("Circle's Area: " + circle.Area(radius));
                        Console.WriteLine("\t\t ******* \t\t");
                        ChooseShape();
                    }else{
                        ChooseShape();
                    }
                    
                    
                    break;
                case 2:
                    Console.Write("Enter the short edge: ");
                    double shortEdge = double.Parse(Console.ReadLine());
                    Console.Write("Enter the long edge");
                    double longEdge = double.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(shortEdge,longEdge);
                    int y = ChooseCalculator();
                    if(y == 1){
                        Console.WriteLine("\t\t ******* \t\t");
                        Console.WriteLine("Rectangle's Perimeter: " + rectangle.Perimeter(shortEdge,longEdge));
                        Console.WriteLine("\t\t ******* \t\t");
                        ChooseShape();
                    }else if(y == 2){
                        Console.WriteLine("\t\t ******* \t\t");
                        Console.WriteLine("Rectangle's Area: " + rectangle.Area(shortEdge,longEdge));
                        Console.WriteLine("\t\t ******* \t\t");
                        ChooseShape();
                    }else{
                        ChooseShape();
                    }

                    break;
                case 3:
                    Console.Write("Enter the edge: ");
                    double edge = double.Parse(Console.ReadLine());
                    Square square = new Square(edge);
                    int z = ChooseCalculator();
                    if(z == 1){
                        Console.WriteLine("\t\t ******* \t\t");
                        Console.WriteLine("Square's Perimeter: " + square.Perimeter(edge));
                        Console.WriteLine("\t\t ******* \t\t");
                        ChooseShape();
                    }else if(z == 2){
                        Console.WriteLine("\t\t ******* \t\t");
                        Console.WriteLine("Square's Area: " + square.Area(edge));
                        Console.WriteLine("\t\t ******* \t\t");
                        ChooseShape();
                    }else{
                        ChooseShape();
                    }
                    break;
                case 4:
                    Console.Write("Enter the first edge: ");
                    double edge1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second edge: ");
                    double edge2 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the third edge: ");
                    double edge3 = double.Parse(Console.ReadLine());
                    Triangle triangle = new Triangle(edge1,edge2,edge3);
                    int w = ChooseCalculator();
                    if(w == 1){
                        Console.WriteLine("\t\t ******* \t\t");
                        Console.WriteLine("Triangle's Perimeter: " + triangle.Perimeter(edge1,edge2,edge3));
                        Console.WriteLine("\t\t ******* \t\t");
                        ChooseShape();
                    }else if(w == 2){
                        Console.WriteLine("\t\t ******* \t\t");
                        Console.WriteLine("Triangle's Area: " + triangle.Area(edge1,edge2,edge3));
                        Console.WriteLine("\t\t ******* \t\t");
                        ChooseShape();
                    }else{
                        ChooseShape();
                    }

                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Please enter valid value!");
                    ChooseShape();
                    break;
                    
            }
        }

        public int ChooseCalculator(){
            
            Console.WriteLine("1- Perimeter\n" + "2- Area\n" + "3- Back to Main Menu\n");
            Console.Write("Your choose: ");
            int choose = int.Parse(Console.ReadLine());
            return choose;
            
        }

    }
}