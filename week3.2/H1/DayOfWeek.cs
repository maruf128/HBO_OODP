class DayOfWeek
{
    public static int dayOfWeek;

    //constructor
    public DayOfWeek(int i)
    {
        dayOfWeek = i;
    }

    public string IndexToDay(int dayOfWeek)
    {
        // indien gegeven dag groter is dan 6 doe - 7
        if (dayOfWeek > 6)
        {
            dayOfWeek -= 7;
        }
        // indien kleiner dan 0 + 7
        else if (dayOfWeek < 0)
        {
            dayOfWeek += 7;
        }
        // anders ga je door naar de switch
        switch (dayOfWeek)
        {
            case 0:
                return $"Monday";
            case 1:
                return $"Tuesday";
            case 2:
                return $"Wednesday";
            case 3:
                return $"Thursday";
            case 4:
                return $"Friday";
            case 5:
                return $"Saturday";
            case 6:
                return $"Sunday";
        }
        return null;
    }
}