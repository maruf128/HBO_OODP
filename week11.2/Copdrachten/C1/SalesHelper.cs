public static class SalesHelper
{
    public static int bijhoudne = 1;
    public static void PrintSalesData(int[][] sales)
    {
        for (int i = 0; i < sales.Length; i++)
        {
            System.Console.Write($"Sales data for department {bijhoudne}:\n");

            for (int j = 0; j < sales[i].Length; j++)
            {
                System.Console.Write(" - {0}{1}", sales[i][j], j == (sales[i].Length - 1) ? "" : " \n");
            }
            System.Console.WriteLine("\n");
            bijhoudne++;
        }
    }
}