class Program
{
    static void Main()
    {
        var john = new Person("John Doe", 28);
        Console.WriteLine(john.Info);

        john.Age = -10;
        Console.WriteLine(john.Info);

        john.Age = 200;
        Console.WriteLine(john.Info);

        var jane = new Person("Jane Doe", 25);
        Console.WriteLine(jane.Info);

        jane.Age = -10;
        Console.WriteLine(jane.Info);

        jane.Age = 200;
        Console.WriteLine(jane.Info);

        var jimmy = new Person("Jimmy Doe", 150);
        Console.WriteLine(jimmy.Info);

        jimmy.Age = -10;
        Console.WriteLine(jimmy.Info);

        jimmy.Age = 200;
        Console.WriteLine(jimmy.Info);

        var jarold = new Person("Jarold Doe", 0);
        Console.WriteLine(jarold.Info);

        jarold.Age = -10;
        Console.WriteLine(jarold.Info);

        jarold.Age = 200;
        Console.WriteLine(jarold.Info);
    }
}
