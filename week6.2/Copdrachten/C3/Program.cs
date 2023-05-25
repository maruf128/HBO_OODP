class Program
{
    static void Main(string[] args)
    {
        // Code to be executed when the application starts
        List<Bill> bills = new List<Bill>();

        // maak de mensen aan
        ElectricityBill johnelek = new ElectricityBill(50, "John Smith");
        ElectricityBill janeelek = new ElectricityBill(75, "Jane Doe");
        GasBill bobgass = new GasBill(100, "Bob Johnson", false);
        GasBill johngass = new GasBill(125, "John Doe", true);

        // add ze nu
        bills.Add(johnelek);
        bills.Add(janeelek);
        bills.Add(bobgass);
        bills.Add(johngass);

        double totaal = 0;
        // loop nu door ze
        foreach (var x in bills)
        {
            Console.WriteLine(x.GetDescription());
            totaal += x.Amount;
        }
        // maak totaal een int
        int Inttotaal = (int)totaal;
        // print dan totaal uit:
        Console.WriteLine($"Total amount: {Inttotaal}");
    }
}
