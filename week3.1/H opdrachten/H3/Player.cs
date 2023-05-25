class Player
{
    public string Name;
    public int Points;
    public int Skill;
    public int Intelligence;
    public int Knowledge;
    // constructor
    public Player(string naam, int vaardigheid, int slimheid, int wetend)
    {
        Name = naam;
        Skill = vaardigheid;
        Intelligence = slimheid;
        Knowledge = wetend;
    }

    public int Score()
    {
        // doe ++ bij score
        Points++;
        return Points;
    }
    public static Player WhoIsWinning(Player player1, Player player2)
    {
        if (player1.Points > player2.Points)
        {
            // aka player 1 wint
            return player1;
        }
        else if (player1.Points == player2.Points)
        {
            // gelijk spel
            return null;
        }
        else if (player2.Points > player1.Points)
        {
            //aka player 2 wint
            return player2;
        }
        // anders idk foutmelding?
        return null;
    }
}