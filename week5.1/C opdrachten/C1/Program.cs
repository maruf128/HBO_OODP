class Program
{
    public static void Main()
    {
        // maak de eerste persoon: jhon doe
        Student persoon1 = new Student("John Doe");
        Console.WriteLine(persoon1.Introduce());

        // maak de tweede persoon: Jane Doe
        Student persoon2 = new Student("Jane Doe");
        Console.WriteLine(persoon2.Introduce());

        // persoon is nog niet geslaagd: joe
        Console.WriteLine(persoon1.Status());

        // zet jane doe op geslaagd
        persoon2.Graduate();
        Console.WriteLine(persoon2.Status());

    }
}