class LimitedEditionCar
{
    public const string Model = "Chevrolet Camaro";
    public readonly string ChassisNumber = "CHNO" + Counter;
    public static int Counter;

    public LimitedEditionCar()
    {
        // hier doe je telkens +1 indien je een nieuwe auto maakt
        Counter++;
        ChassisNumber = "CHNO" + Counter;
    }

    public string GetChassisNumber()
    {
        // geef de nummer terug
        return ChassisNumber;
    }
}
