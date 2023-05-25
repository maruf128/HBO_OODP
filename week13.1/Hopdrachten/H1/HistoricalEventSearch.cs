using Newtonsoft.Json;

public static class HistoricalEventSearch
{
    public static List<HistoricalEvent> ReadEvents(string dataset)
    {
        StreamReader reader = new StreamReader(dataset);
        string jsonString = reader.ReadToEnd();
        reader.Close();
        return JsonConvert.DeserializeObject<List<HistoricalEvent>>(jsonString)!;
    }
    // de methods:
    public static List<HistoricalEvent> SearchInDescription(List<HistoricalEvent> lijst, string zoeken)
    {
        // maak de lijst alvast aan
        List<HistoricalEvent> gegevens = new List<HistoricalEvent>();
        // je hebt gegevens in de lijst, in de lijst moet je description pakken
        foreach (var x in lijst)
        {
            if (x.Description.IndexOf(zoeken, 0, StringComparison.OrdinalIgnoreCase) != -1) // als het de parameter bevat
            {
                gegevens.Add(x);
            }
        }
        return gegevens;
    }
    public static List<HistoricalEvent> SearchBetweenYears(List<HistoricalEvent> lijst, int begin, int einde)
    {
        // maak de lijst alvast aan
        List<HistoricalEvent> gegevens = new List<HistoricalEvent>();
        // je hebt gegevens in de lijst, in de lijst moet je tussen de jaren gaan kijken
        foreach (var x in lijst)
        {
            if (x.Year >= begin && x.Year <= einde)
            {
                //het is dus groter of gelijk aan de jaar en kleiner dan of gelijk aan de einde
                gegevens.Add(x);
            }
        }
        return gegevens;
    }
    public static int AverageEventYear(List<HistoricalEvent> lijst)
    {
        int tot = lijst.Sum(x => x.Year); // lambda deed het eerst zoals functie's hierboven maar codegrade wilt een lambda
        int gemiddeld = tot / lijst.Count;
        return gemiddeld;
    }
}