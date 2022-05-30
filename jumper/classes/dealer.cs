// a system that keeps the game running, and decide what is the next step

public class Dealer
{
    private List<string> UserInputs = new List<string>() {"_", "_", "_", "_", "_"};
    private List<int> indexs = new List<int>();
    private List<string> inputHistory = new List<string>();
    private int keeplay = 1;
    Words newWord = new Words();
    Player player = new Player();
    public Dealer()
    {

    }

    public void GameStart()
    {
        newWord.Letters();
        // newWord.PrintLetter();
        Console.WriteLine(String.Join(" ", UserInputs));
        player.UpdateLife();
        while (keeplay == 1)
        {
            keeplay = GetInput();

            if (keeplay == 2)
            {
                Console.WriteLine("You Won! Good Game!");
                break;
            }
            if (keeplay == 0)
            {
                string word = newWord.PrintWord();
                Console.WriteLine($"The word was {word}.");
            }
        }
    }

    private int GetInput()
    {
        int safe = 1;
        bool guess = true;
        
        string input = CheckInput();
        char character = char.Parse(input);
        indexs = newWord.GetIndex(character);
        if (indexs[0] > -1)
        {
            foreach (int index in indexs)
            {
                UserInputs[index] = input;
            }
        }
        else
        {
            guess = false;
        }
        Console.WriteLine(String.Join(" ", UserInputs));
        player.UpdateLife(guess);
        int life = player.Life();

        if (life == 0)
        {
            safe = 0;
        }
        else if (UserInputs.Contains("_") == false)
        {
            safe = 2;
        }

        return safe;
    }

    private string CheckInput()
    {
        string[] alphabets = 
        {"a","b","c","d","e","f","g","h","i","j","k","l","m",
        "n","o","p","q","r","s","t","u","v","w","x","y","z"};
        string input = "";
        while(true)
        {
            Console.Write("Guess a letter [A-Z]: ");
            input = Console.ReadLine().ToLower();
            if (input.Length == 1)
            {
                if (alphabets.Contains(input))
                {
                    if (inputHistory.Contains(input) == false)
                    {
                        inputHistory.Add(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{input} is guessed already, please try a new alphabet.");
                    }
                }
                else
                {
                    Console.WriteLine($"{input} is not a vaild input, please only guess between [A-Z]");
                }
            }
            else
            {
                Console.WriteLine("Please only input 1 character at a time");
            }
        }
        return input;
    }

    
}