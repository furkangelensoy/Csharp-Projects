public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the word: ");
        string word = Console.ReadLine();
        char tempChar =' ';
        string result = "";
        char[] newWord = word.ToCharArray();

        tempChar = newWord[0];
        newWord[0] = newWord[newWord.Length-1];
        newWord[newWord.Length-1] = tempChar;

        foreach(var item in newWord){
            result += item;
        }

        Console.WriteLine("New word: " + result);
    }
}