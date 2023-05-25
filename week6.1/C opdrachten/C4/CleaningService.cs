static class CleaningService
{
    public static void Clean(ICleanable schoonmaken) // je maak een nieuwe clean object
    {
        schoonmaken.Clean();
    }

    public static void Clean(List<ICleanable> plekken) // maak een list met icleanable als object
    {
        foreach (var spot in plekken)
        {
            spot.Clean();
        }
    }
}