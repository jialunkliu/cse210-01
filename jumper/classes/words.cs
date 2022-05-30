// Choose a random word from a list, seperate it into letters
public class Words
{
    private string theWord = "";
    private char[] wordSplit = {};
    
    private string RandomWord()
    {
        Random GetRandom = new Random();
        int ranIndex = GetRandom.Next(0,41);
        
        string[] words = new[]
        {
            "hello", "apple", "abuse", "admit", "alive",
            "among", "apart", "avoid", "aside", "again",
            "basic", "beach", "billy", "birth", "blind",
            "brain", "break", "build", "broke", "blood",
            "close", "could", "coach", "clock", "crash",
            "death", "dozen", "drive", "dream", "dying",
            "earth", "enemy", "enjoy", "enter", "error",
            "frank", "fruit", "found", "forth", "focus"

        };

        theWord = words[ranIndex];

        return theWord;
    }

    public string PrintWord()
    {
        return theWord;
    }

    public void Letters()
    {
        string word = RandomWord();
        wordSplit = word.ToCharArray();
    }

    public void PrintLetter()
    {
        foreach (char letter in wordSplit)
        {
            Console.WriteLine($"substring: {letter}");
        }

        // Console.WriteLine(textSplit[2]);
        // Console.WriteLine(textSplit[4]);
        
    }

    public List<int> GetIndex(char aLetter)
    {
        List<int> indexs = new List<int>();
        int index = 0;
        if (Array.IndexOf(wordSplit, aLetter) > -1)
        {
            foreach (char letter in wordSplit)
            {
                if (letter == aLetter)
                {
                    indexs.Add(index);
                }
                index += 1;
            }
        }
        else
        {
            indexs.Add(-1);
        }
        // Console.WriteLine(String.Join(" ", indexs));
        return indexs;
    }
}