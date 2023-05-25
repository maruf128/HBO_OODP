using Newtonsoft.Json;
static class Calculator
{

    public static double Add(double getal1, double getal2)
    {
        // plus elkaar
        return getal1 + getal2;
    }

    public static double Subtract(double getal1, double getal2)
    {
        // min elkaar
        return getal1 - getal2;
    }

    public static double Multiply(double getal1, double getal2)
    {
        // keer elkaar
        return getal1 * getal2;
    }

    public static double Divide(double getal1, double getal2)
    {
        // tbh idk wat dit doet, dacht dat het was voor even te kijken
        return getal1 / getal2;
    }

    public static double Modulo(double getal1, double getal2)
    {
        // tbh idk wat dit doet, dacht dat het was voor even te kijken
        return getal1 % getal2;
    }

    // functie bewaren
    public static void StoreInMemory(double getal)
    {
        var fileName = "Memory.json";
        StreamWriter writer = new StreamWriter(fileName); //fileName is "Memory.json"
        writer.Write(JsonConvert.SerializeObject(getal));
        writer.Close();
    }
    // functie uitlezen
    public static double RestoreFromMemory()
    {
        var fileName = "Memory.json";
        StreamReader reader = new StreamReader(fileName); //fileName is "Memory.json"
        string jsonString = reader.ReadToEnd();
        reader.Close();
        var fromjson = JsonConvert.DeserializeObject<double>(jsonString)!;
        return fromjson;
    }
}