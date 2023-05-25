class Program
{
    public static void Main()
    {
        Person john = new("John Doe");
        Student jane = new("Jane Doe");
        //Write your code here
        List<Person> Lijst = new List<Person>();

        Lijst.Add(john);
        Lijst.Add(jane);
        foreach (var naam in Lijst)
        {
            Console.WriteLine(naam.Introduce());
            if (naam is Student)
            {
                Student student = new(naam.Name);
                Console.Write(student.Status());
            }
        }
    }
}