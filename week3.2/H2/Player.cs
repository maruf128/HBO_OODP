public class Player
{
    // een speler heeft 3 atributes
    public string naam;
    public double hp;
    public double sterkte;

    // constructor
    public Player(string PlayerName, int PlayerBaseHP, int PlayerBaseStrength)
    {
        naam = PlayerName;
        hp = PlayerBaseHP;
        sterkte = PlayerBaseStrength;
    }
    public string Name()
    {
        return naam;
    }

    public bool IsAlive()
    {
        // indien het geen hp meer heeft return true
        if (hp < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}