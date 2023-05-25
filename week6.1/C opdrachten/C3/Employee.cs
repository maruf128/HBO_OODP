public class Employee : IPayable
{
    private string _name;
    public double Salary { get; set; }
    public int EmployeeId { get; set; }
    public static int EmployeeCounter = 0;

    public Employee(string name, double salary)
    {
        _name = name;
        Salary = salary;
        EmployeeId = ++EmployeeCounter;
    }
    public string Name { get { return _name; } set { _name = value; } }
    public double GetPaymentAmount()
    {
        return Salary;
    }
    public string Info
    {
        get { return $"ID: {EmployeeId} ({Name}); {GetPaymentAmount()}/month"; }
    }
}