namespace AverageCalculator{
    public class Calculate{
        
        public double Average(int[] array){

            int sum = 0;
            for(int i = 0; i < array.Length; i++){
                sum += array[i];
            }

            double average =(double)sum / array.Length;
            return average;
        }
    }
}