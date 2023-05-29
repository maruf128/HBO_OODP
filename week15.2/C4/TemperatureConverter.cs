public enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin
}

public static class TemperatureConverter
{
    public static string ConvertToString(TemperatureUnit unit)
    {
        switch (unit)
        {
            case TemperatureUnit.Celsius:
                return "C";
                break;
            case TemperatureUnit.Fahrenheit:
                return "F";
                break;
            case TemperatureUnit.Kelvin:
                return "K";
                break;
            default:
                throw new ArgumentException("Invalid temperature unit");
        }
    }
    public static TemperatureUnit ConvertToEnum(string unit)
    {
        switch (unit)
        {
            case "C":
                return TemperatureUnit.Celsius;
                break;
            case "F":
                return TemperatureUnit.Fahrenheit;
                break;
            case "K":
                return TemperatureUnit.Kelvin;
                break;
            default:
                throw new ArgumentException("Invalid temperature unit string");
        }
    }
}