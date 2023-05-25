class Program
{
    static void Main(string[] args)
    {
        // Create the first artifact object
        Artifact artifact1 = new Artifact(10, 200);

        Console.WriteLine("The fields have been implemented correctly");
        Console.WriteLine("First artifact");
        Console.WriteLine($" Value: {artifact1.GetValue()}");

        // Create the second artifact object
        Artifact artifact2 = new Artifact(15, 200);
        Console.WriteLine("Second artifact");
        Console.WriteLine($" Value: {artifact2.GetValue()}");

        // Test the isEqualTo method
        Console.WriteLine("Method isEqualTo has been correctly implemented:");
        Console.WriteLine(artifact1.IsEqualTo(artifact2));
    }
}