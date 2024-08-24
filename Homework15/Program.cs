namespace Homework15;

class Program
{
    static void Main(string[] args)
    {
        string word = "true";
    //  bool isNewWord = Convert.ToBoolean(word);
        bool isNewWord = bool.Parse(word);
        
        System.Console.WriteLine(isNewWord);

        //bool result = isNewWord;
        //System.Console.WriteLine(result);

    }
}
