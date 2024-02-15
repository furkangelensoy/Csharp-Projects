using System.Xml.XPath;

namespace DualSum{
    public class Sum{

        public void TakeNumbers(int count){
            int[] numbers = new int[count];
            int[] oddIndex = new int[count/2];
            int[] evenIndex = new int[count/2];
            int i = 0;
            int tempCount = count;
            while(tempCount > 0){
                Console.Write("Enter the " + (i+1) +". number: ");
                numbers[i] = int.Parse(Console.ReadLine());
                i++;
                tempCount--;
            }
            int even = 0;
            for(int j = 0; j < count; j += 2){
                evenIndex[even] = numbers[j];
                even++;
            }
            int odd = 0;
            for(int k = 1; k < count; k +=2){
                oddIndex[odd] = numbers[k];
                odd++;

            }
            for(int f=0; f < count/2; f++){
                int result = oddIndex[f] + evenIndex[f];
                if(oddIndex[f] == evenIndex[f]){
                    result = (int)Math.Pow(result,2);
                }
                Console.Write(result + ", ");
            }
        }
    }
}