class PlayingCard
{
    public string Suit;
    public string Rank;

    // enigste wat gedaan moest worden is de void weg halen ;-;
    public PlayingCard(string suit, string rank)
    {
        this.Suit = suit;
        this.Rank = rank;
    }

    public string Description() => $"The {this.Rank} of {this.Suit}";
}