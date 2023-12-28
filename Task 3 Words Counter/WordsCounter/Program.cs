using System.IO;
using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Enter Path to count :");
        string? filepath = Console.ReadLine();
        try{
            if(File.Exists(filepath)){
                string content = File.ReadAllText(filepath);
                //TODO 
               int charCount = CharCount(content);
               int sentanceCount =WordCount(content);
               int sen_count = SentanceCount(content);
               System.Console.WriteLine($"Characters Count : {charCount}");
               Console.WriteLine($"Word Count: {sentanceCount}");
                Console.WriteLine($"Sentence Count: {sen_count}");
            }
            else {
                System.Console.WriteLine("Wrong Path Try Agin ... ");
            }
        }catch(Exception ex){
            System.Console.WriteLine($"Exception : Error {ex}");
        }
        
    }
    public static int CharCount(string text){
        return text.Length;
    }
    public static int WordCount(string text){
        MatchCollection matches = Regex.Matches(text,@"\b\w+\b");
        return matches.Count;
    }
    public static int SentanceCount(string text) {
        MatchCollection matches = Regex.Matches(text,@"[.?!]");
        return matches.Count;


    }
}