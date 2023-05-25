using System.Text;
public class Car
{
    public string Make { get; }
    public string Model { get; }
    private readonly Tire[] Tires = new Tire[4];

    public Car(string make, string model, string brand)
    {
        Make = make;
        Model = model;
        for (int i = 0; i < 4; i++)
        {
            Tires[i] = new Tire(brand);
        }
    }

    public bool TryDrive()
    {
        bool rijden = true;
        foreach (Tire band in Tires)
        {
            if (band.Durability < 1)
            {
                rijden = false;
                break;
            }
        }

        if (rijden)
        {
            foreach (Tire band in Tires)
            {
                band.Durability--;
            }
        }

        return rijden;
    }

    public void ReplaceTire(Tire niewueband, int band)
    {
        Tires[band] = niewueband;
    }

    public void ReplaceTire(string bandnaam, int band)
    {
        Tires[band] = new Tire(bandnaam);
    }

    public string GetTireInfo()
    {
        var text = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            text.AppendLine($"Tire {i + 1}: Brand: {Tires[i].Brand}, Durability: {Tires[i].Durability}");
        }
        return text.ToString();
    }
}