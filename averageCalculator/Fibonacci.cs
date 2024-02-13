namespace AverageCalculator{
    public class Fibonacci{

        public int[] FibonacciSeries(int depth){

            int[] array = new int[depth];
            int number1 = 0, number2 = 1, number3;
            array[0] = 0;
            array[1] = 1;

            for(int i = 2; i < array.Length; i++){

                number3 = number1 + number2;
                array[i] = number3;
                number1 = number2;
                number2 = number3;

            }

            return array;


        }

    }
}