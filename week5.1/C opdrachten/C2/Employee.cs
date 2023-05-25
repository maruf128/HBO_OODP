public class Employee : Person
{
    public double Salary;
    public Employee(string name, double salaris) : base(name)
    {
        Salary = salaris;
    }
}