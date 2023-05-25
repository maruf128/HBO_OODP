using System;
class Program
{
    static void Main()
    {
        // maak hier de lijst aan
        var pack = new List<string>();

        // maak variable waar je de aantal gaat optellen
        int aantal;
        // print dan de amount of taskes
        aantal = pack.Count;
        Console.WriteLine($"Amount of tasks: {aantal}");

        // voeg hier items toe
        pack.Add("Mow lawn");
        pack.Add("Pay taxes");

        // print eerst hoeveel items er nu in zitten
        aantal = pack.Count;
        Console.WriteLine($"Amount of tasks: {aantal}");

        // print nu de lijst met items
        foreach (string s in pack)
        {
            Console.WriteLine(s);
        }


        // verwijder mow lawn
        pack.Remove("Mow lawn");
        pack.Add("Shopping");

        // print eerst hoeveel items erin zitten
        aantal = pack.Count;
        Console.WriteLine($"Amount of tasks: {aantal}");

        // print now the updated list
        foreach (string s in pack)
        {
            Console.WriteLine(s);
        }

    }
}