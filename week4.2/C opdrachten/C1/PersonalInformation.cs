public static class PersonalInformation
{
    // overloads van classes zijn dat je ze gemakkelijk meerdere keren kan gebruiken maar 
    // indien meerdere gegevens of andere data types worden opgegeven pak je de juiste class erbij die het aankan
    public static void PrintName(string text)
    {
        string gegeven = text;
        // doe altijd moet "" en $ zodat je altijd later gemakkelijk text bij kan adden en extra variables
        Console.WriteLine($"{text}");
    }
    public static void PrintName(string text1, string text2)
    {
        string gegeven1 = text1;
        string gegeven2 = text2;
        Console.WriteLine($"{text1} {text2}");
    }
    public static void PrintName(char single, string text)
    {
        char charachter = single;
        string gegeven = text;
        Console.WriteLine($"{single}. {text}");
    }
    // volgende overloads
    public static int IncreaseSalary(int getal)
    {
        int salaris = getal;
        int extra = 100;
        int totaal = salaris + extra;
        // sinds het een int moet zijn return je de int los
        return totaal;
    }
    public static double IncreaseSalary(int getal, double decimaal)
    {
        int salaris = getal;
        double plus = 1 + decimaal;
        double totaal = salaris * plus;
        // sinds het een double zijn return je nu de double
        return totaal;
    }
}
