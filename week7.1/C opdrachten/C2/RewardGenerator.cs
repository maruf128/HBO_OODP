static class RewardGenerator
{
    private static Random _random = new Random(0);

    public static T GetRandomElement<T>(List<T> list) // krijg de lijst
    {
        int index = _random.Next(list.Count);
        return list[index];
    }
}
