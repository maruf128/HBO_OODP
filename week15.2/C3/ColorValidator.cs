// Create the public enum Color
// with Red, Green and Blue here
public enum Color
{
    Red,
    Green,
    Blue
}


public static class ColorValidator
{
    public static void DisplayColors()
    {
        // Print all the colors here.
        // Make sure of Enum.GetValues() with typeof(Color)
        // to get an array with all the colors.
        foreach (var kleur in Enum.GetValues(typeof(Color)))
        {
            Console.WriteLine(kleur);
        }

    }

    public static bool ValidateColor(string input)
    {
        // Print "Valid color: " plus the color and return true, if it is valid
        // Print "Invalid color" and return false otherwise.
        // krijg eerst de kleur out een string
        if (!Enum.TryParse(input, out Color kleur))
        {
            Console.WriteLine("Invalid color");
            return false;
        }
        // nu heb je de kleur doe de rest
        Console.WriteLine($"Valid color: {kleur}");
        return true;
    }
}