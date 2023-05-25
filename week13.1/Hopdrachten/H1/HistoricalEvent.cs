public class HistoricalEvent
{
    public string Date { get; set; }
    public string Description { get; set; }
    public string Language { get; set; }
    public string Category1 { get; set; }
    public string Category2 { get; set; }
    public string Granularity { get; set; }
    public int Year
    {
        get
        {
            if (!string.IsNullOrEmpty(Date))
            {
                string[] words = Date.Split('/');
                int jaar = int.Parse(words[0]);
                return jaar;
            }

            throw new InvalidOperationException("Invalid date format or null value.");
        }
    }


    public HistoricalEvent(string date, string description, string language, string category1, string category2, string granularity)
    {
        Date = date;
        Description = description;
        Language = language;
        Category1 = category1;
        Category2 = category2;
        Granularity = granularity;
    }
}