public enum Month // Change the numbering, so that it starts at 1
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

public class Calendar
{
    private Month _currentMonth;

    public Calendar(Month initialMonth)
    {
        _currentMonth = initialMonth;
    }

    public void DisplayCurrentMonth()
    {
        int maand = (int)_currentMonth; // enum to int conversion
        Console.WriteLine($"Current month: {_currentMonth} ({maand})"); // Add the month number
    }

    // SetNextMonth goes here. It updates the current month to the next one.
    public void SetNextMonth()
    {
        // krijg de aantal values in de enum
        int numberOfValues = Enum.GetValues(typeof(Month)).Length;
        if ((int)_currentMonth >= numberOfValues)
        {
            _currentMonth = Month.January;
        }
        else
        {
            _currentMonth++;
        }
    }
}