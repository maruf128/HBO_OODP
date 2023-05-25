public class Consultant : IPayable
{
    private string _name;
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public Consultant(string name, double hourlyRate)
    {
        _name = name;
        HourlyRate = hourlyRate;
    }
    public string Name { get { return _name; } set { _name = value; } }
    public double GetPaymentAmount()
    {
        return Convert.ToDouble(HoursWorked * HourlyRate);
    }
    public string Info
    {
        get { return $"{Name}; {HourlyRate}/hour"; }
    }
}