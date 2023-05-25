class Job
{
    public string Name;
    public double Salary;

    public Job(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public Job BiggestSalary(Job that) => this.Salary > that.Salary ? this : that;
}
class Person
{
    // eerst zet je de firstname en lastname op get en set zodat je makkelijker toegang hebt
    public string Name { get; set; }
    public Job DayJob { get; set; }

    public Person(string naam, Job Job)
    {
        // hier zet je de opgegeven strings in een variable zodat je ze in de latere functie's kan gebruiken
        Name = naam;
        DayJob = Job;
    }

    // indien er niks is zegt dat die geen job heeft vergeten dat het in between moet zijn ipc has no job
    public string Info() => DayJob != null ? $"{Name} works as a {DayJob.Name}" : $"{Name} is in between jobs";
}
class Program
{
    public static void Main()
    {
        var jobs = new List<Job> {
            new Job("Waiter", 25000.0),
            new Job("Clown", 10000.0),
            new Job("Developer", 90000.0),
        };

        Person person = new Person("Jane", jobs[0]);
        Console.WriteLine(person.Info());

        for (int i = 1; i < jobs.Count; i++)
        {
            person.DayJob = person.DayJob.BiggestSalary(jobs[i]);
        }
        Console.WriteLine(person.Info());

        person.DayJob = null;
        Console.WriteLine(person.Info());
    }
}