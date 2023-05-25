class Program
{
    static void Main(string[] args)
    {
        Employee John = new Employee("John", "Doe", "john.doe@example.com");
        Manager Jane = new Manager("Jane", "Doe", "jane.doe@example.com", "Sales");
        SalesPerson Bob = new SalesPerson("Bob", "Smith", "bob.smith@example.com", 100000);
        // maak een lijst om het makkelijker te maken
        List<Employee> personen = new List<Employee>();
        personen.Add(John);
        personen.Add(Jane);
        personen.Add(Bob);
        // eerst de info
        foreach (var x in personen)
        {
            x.PrintEmployeeInfo();
        }
        // dan eigen rol
        foreach (var x in personen)
        {
            if (x is Manager)// indien manager
            {
                Manager apart = (Manager)x;
                apart.PrintEmployeeInfo();
            }
            else if (x is SalesPerson)
            {
                SalesPerson apart = (SalesPerson)x;
                apart.PrintEmployeeInfo();
            }
            else
            {
                x.PrintEmployeeInfo();
            }
        }
    }
}
