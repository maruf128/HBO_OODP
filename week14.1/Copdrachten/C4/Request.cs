public class Request
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string CustomerName { get; set; }

    public Request(string naam, string beschrijving, string Cnaam)
    {
        Name = naam;
        Description = beschrijving;
        CustomerName = Cnaam;
    }

    public override string ToString()
    {
        string text = $"Name: {Name}\n";
        text += $"Description: {Description}\n";
        text += $"Customer Name: {CustomerName}";
        return text;
    }
}