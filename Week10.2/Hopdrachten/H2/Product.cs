public class Product : IComparable<Product>
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Product(string naam, int prijs, int aantal)
    {
        Name = naam;
        Price = prijs;
        Quantity = aantal;
    }
    public bool Equals(Product item)
    {
        if (item == null) // aka hij is leeg
        {
            return false;
        }
        // kijk of het gelijk is
        if (this.Name == item.Name)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override bool Equals(object item)
    {
        if (item == null)
        {
            return false;
        }
        if (item is Product)
        {
            // dus als het een persoon is roep dan allen de andere equals aan
            Product person = (Product)item; // maak er een person object van
            return Equals(person); // return the result of the call to Equals(Person item) method
        }
        return false;
    }
    public int CompareTo(Product other)
    {
        if (other == null)
        {
            return 1;
        }

        int result = this.Price.CompareTo(other.Price);

        if (result == 0)
        {
            result = this.Name.CompareTo(other.Name);
        }

        return result;
    }

    public override string ToString()
    {
        string text = $"{Name} ({Price} x {Quantity})";
        return text;
    }

}