// A class that generate a random card from 1 ~ 13
public class Card
{
    Random random = new Random();
    
    public Card()
    {

    }

    public int GetNewCard()
    {
        int card = random.Next(1, 14);
        return card;
    }
}