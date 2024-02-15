namespace AbsoluteSquare{
    public class TakeNumbers{

        public int[] Numbers(int n){
            int[] numbers = new int[n];
            int i = 0;
            while(n > 0){
                Console.Write("Enter the " + (i+1) + ". number: ");
                numbers[i] = int.Parse(Console.ReadLine());
                n--;
                i++;
            }

            return numbers;
        }

        public void Calculate(int[] numbers){
            int smaller = 0;
            double bigger = 0;
            int value = 67;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] <= value){
                    smaller += value - numbers[i];
                }else{
                    bigger += Math.Pow(Math.Abs(value - numbers[i]),2);
                }
            }
            Console.WriteLine("******************Result******************");
            Console.WriteLine("According to its distance sixty-seven;");
            Console.WriteLine("Sum of numbers smaller than sity-seven: " + smaller);
            Console.WriteLine("Absolute Sqaure's sum of numbers bigger than sixty-seven: " + bigger);
        }
    }
}