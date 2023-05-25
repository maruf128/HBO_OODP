class Card
{
    public readonly string Suit;
    public readonly string Rank;

    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public string GetName()
    {
        if (Suit == "Joker")
        {
            // indien het een joker is
            return $"{Rank} {Suit}";
        }
        else
        {
            // anders is het een andere kaart
            return $"{Rank} of {Suit}";
        }
    }
}
class Deck
{
    public readonly List<Card> Cards;
    public readonly bool AreJokersIncluded;

    public Deck(bool jokersIncluded)
    {
        Cards = new List<Card>();
        AreJokersIncluded = jokersIncluded;

        // Add standard playing cards
        // voor iedere soort kaart dat er is plak je hem
        foreach (string suit in new string[] { "Diamonds", "Clubs", "Hearts", "Spades" })
        {
            for (int rank = 1; rank <= 13; rank++)
            {
                string rankName;
                switch (rank)
                {
                    case 1:
                        rankName = "Ace";
                        break;
                    case 11:
                        rankName = "Jack";
                        break;
                    case 12:
                        rankName = "Queen";
                        break;
                    case 13:
                        rankName = "King";
                        break;
                    default:
                        rankName = rank.ToString();
                        break;
                }

                Card card = new Card(suit, rankName);
                Cards.Add(card);
            }
        }

        if (AreJokersIncluded)
        {
            // indien jokers mogen maak deze 2 kaarten aan
            Card redJoker = new Card("Joker", "Red");
            Card blackJoker = new Card("Joker", "Black");
            // en voeg ze toe aan de list
            Cards.Add(redJoker);
            Cards.Add(blackJoker);
        }
    }
    // nieuwe constructoir
    public Deck() : this(false)
    {
        // aka wnr er geen bool word meegegeven geven we het false mee anders roep je de deck op met de bool die is meegegeven
    }

    public void Shuffle()
    {
        // maak de random aan en doe het bij een lijst
        Random rand = new Random();
        Cards.OrderBy(card => rand.Next()).ToList();
    }

    // de draw die een int neemt
    public List<Card> Draw(int numCards)
    {
        // hierdoor kan je een lijst met cards terug geven
        List<Card> drawnCards = new List<Card>();
        // voor de hoeveel heid kaarten dat is opgegeven maak je een kaart aan en add je het
        for (int i = 0; i < numCards; i++)
        {
            if (Cards.Count == 0)
            {
                // indien de count 0 is voeg je 0 toe
                drawnCards.Add(null);
            }
            else
            {
                // anders maak je een nieuwe card aan en add je het
                Card card = Cards.Last();
                Cards.RemoveAt(Cards.Count - 1);
                drawnCards.Add(card);
            }
        }
        // uiteindelijk erturn je de list
        return drawnCards;
    }

    // normale die een kaart geeft
    public Card Draw()
    {
        if (Cards.Count == 0)
        {
            return null;
        }

        Card card = Cards.Last();
        Cards.RemoveAt(Cards.Count - 1);
        return card;
    }

}