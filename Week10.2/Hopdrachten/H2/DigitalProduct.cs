public class DigitalProduct : Product
{
    public string DownloadUrl { get; set; }
    public DigitalProduct(string naam, int prijs, int aantal, string url) : base(naam, prijs, aantal)
    {
        DownloadUrl = url;
    }
}