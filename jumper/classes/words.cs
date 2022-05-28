// Choose a random word from a list, seperate it into letters
public class Words
{
    private string theWord;
    
    private string RandomWord()
    {
        Random GetRandom = new Random();
        int ranIndex = GetRandom.Next(0,3);
        
        string[] words = new[]
        {
            "hello", "apple", "string"
        };

        theWord = words[ranIndex];

        return theWord;
    }

    public void PrintWord()
    {
        Console.WriteLine(theWord);
    }

    public Array Letters()
    {
        string word = RandomWord();
        char[] textSplit = word.ToCharArray();

        return textSplit;
    }

    public void PrintLetter()
    {
        Array textSplit = Letters();
        foreach (char letter in textSplit)
        {
            Console.WriteLine($"substring: {letter}");
        }
    }
}