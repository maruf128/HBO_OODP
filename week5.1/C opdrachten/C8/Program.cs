using static System.Formats.Asn1.AsnWriter;

public class Program
{
    public static void Main()
    {
        //Retrieving employees from a database or a file
        List<object> employees = new()
        {
            new Employee(1, "Miles Dyson", "Developer"),
            new Employee(2, "Coleman Reese", "Lawyer"),
            new Manager (3, "Bill Lumbergh", "Manager", 5),
            new Manager (4, "Michael Scott", "Manager", 10),
            new Dog("Owney the mascot dog") //Not an employee
        };
        ListDirectReports(employees);
    }

    public static void ListDirectReports(List<object> employees)
    {
        // Loop through the objects in the list
        foreach (var person in employees)
        {
            // maak nu een manager aan om te kijken of het een manager is
            Manager manager = person as Manager;

            // Then if not null, print (depending on the Manager's fields):
            if (manager != null)
            {
                // "Manager Bill Lumbergh has 5 direct reports."
                System.Console.WriteLine($"Manager {manager.Name} has {manager.DirectReportsCount} direct reports.");
            }
        }
    }
}