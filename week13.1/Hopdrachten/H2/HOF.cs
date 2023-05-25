public static class HOF
{
    // Filter goes here
    public static List<T> Filter<T>(List<T> lijst, Func<T, bool> emp)
    {
        return lijst.Where(emp).ToList();
    }
}