public class Program
{
    public static void Main()
    {
        // vraag eerst hoeveel deparments
        Console.WriteLine("hoeveel deparments zijn er?");
        int aantal_departments = Convert.ToInt32(Console.ReadLine());
        int[][] jaggedArray = new int[aantal_departments][];
        for (int i = 0; i < aantal_departments; i++)
        {
            Console.Write($"aantal sales {i + 1}: ");
            string input = Console.ReadLine();
            // plaats de input in een string array en split het
            string[] sales = input.Split(' ');
            // split ze zodat je ze makkelijker in de array kan plaatsen
            int[] salesarray = new int[sales.Length];
            // voor de lengte maak je een array aan
            for (int j = 0; j < sales.Length; j++) // zolang de lengte door gaat pak iedere getal van de string en plaats get in de sales array
            {
                salesarray[j] = Convert.ToInt32(sales[j]);
            }
            jaggedArray[i] = salesarray;
        }
        SalesHelper.PrintSalesData(jaggedArray);
    }
}