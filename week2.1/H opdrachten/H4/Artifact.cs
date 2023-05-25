public class Artifact
{
    public double Rarity { get; set; }
    public double Condition { get; set; }

    public Artifact(double rarity, double condition)
    {
        Rarity = rarity;
        Condition = condition;
    }

    public double GetValue()
    {
        return Rarity * Condition;
    }

    public string Appraise()
    {
        return $"Value: {GetValue()}";
    }

    public bool IsEqualTo(Artifact other)
    {
        if (Rarity == other.Rarity && Condition == other.Condition)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
