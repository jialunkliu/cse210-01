// This class will call player class to determine if the player can keep playing the game

public class Dealer
{
    public void StartGame()
    {
        Console.WriteLine("Welcome to our Hilo Game!");
        Player player = new Player();
        int score = player.ShowScore();
        string keepPlay = "y";
        List<int> deck = new List<int>();

        Card card = new Card();
        int nextNum = card.GetNewCard();

        while (keepPlay != "n")
        {
            deck = card.DealwNextCard(nextNum);
            int curNum = deck[0];
            Console.WriteLine($"The card is: {curNum}");
            string guess = "";
            while (true)
            {
                Console.Write("Higher or lower? [h/l]" );
                guess = Console.ReadLine();
                if (guess.ToLower() == "l" || guess.ToLower() == "h")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{guess} is not a vaild input, please try again.");
                }
            }

            nextNum = deck[1];
            Console.WriteLine($"Next card is: {nextNum}");

            score = player.GetScore(curNum, nextNum, guess); 
            Console.WriteLine($"Your score is: {score}");
            
            if (score > 0)
            {
                Console.Write("Play again? [y/n] ");
                keepPlay = Console.ReadLine().ToLower();
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("\nYour score reached zero or below.");
                Console.WriteLine("GAME OVER");
                break;
            }
        }

        Console.WriteLine("Thank you for playing!");

        
    }
}