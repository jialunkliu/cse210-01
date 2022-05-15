// Create a player file with a start of 300 points
public class Player
{
    private int score = 300;

    public Player()
    {

    }

    public int GetNewNum()
    {
        Card card = new Card();
        int number = card.GetNewCard();
        return number;
    }

    public int GetScore(int number, int nextNum, string guess)
    {
        if ((guess.ToLower() == "l" && nextNum < number) || (guess.ToLower() == "h" && nextNum > number))
        {
            score += 100;
        }
        else
        {
            score -= 75;
        }
        return score;
    }

    public int ShowScore()
    {
        return score;
    }
}