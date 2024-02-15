using System.Text.RegularExpressions;

public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the word: ");
        string word = Console.ReadLine();
        string lowerWord = word.ToLower();
        string vowelss = "aeıioöuü";
        int count = 0;
        for(int i = 0; i < lowerWord.Length; i++){
            if(!vowelss.Contains(lowerWord[i])){
                count++;
                if(count == 2){
                    break;
                }
            }else{
                count = 0;
            }
        }

        if(count >= 2){
            Console.WriteLine("True");
        }else{
            Console.WriteLine("False");
        }
    }
}