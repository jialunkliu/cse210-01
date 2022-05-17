// A class that generate a random card from 1 ~ 13, and deal with the current and new card
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

    public List<int> DealwNextCard(int nextCard)
    {
        List<int> deck = new List<int>();
        deck.Add(nextCard);
        int nextNewCard = GetNewCard();
        deck.Add(nextNewCard);

        return deck;
    }
}