public class IDEFactory : IFactory<IDE>
{
    public IDE CreateDarkTheme()
    {
        return new IDE("Black", "White", "Light yellow");

    }

    public IDE CreateLightTheme()
    {
        return new IDE("White", "Black", "Light blue");

    }
}