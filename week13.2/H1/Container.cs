public class Container
{
    public string Code { get; set; }
    public string Manifest { get; set; }
    public string[] Categories { get; set; }
    public string Origin { get; set; }
    public int Status { get; set; }
    public double Weight { get; set; }

    public Container(string code, string manifest, string[] categories, string origin, string weight)
    {
        Code = code;
        Manifest = manifest;
        Categories = categories;
        Origin = origin;
        Status = 0;
        weight = weight.Replace(" lbs", "");
        double Weight = double.Parse(weight);
        // double Weight = pound * 0.45359237;
    }

    public override string ToString()
    {
        // Display weight in kilograms and grams as a single double value
        return $"Container(Code:'{Code}', Manifest:'{Manifest}', Categories:'{string.Join(",", Categories)}', Origin:'{Origin}', Status:'{Status}', Weight:'{Weight}')";
    }
}
