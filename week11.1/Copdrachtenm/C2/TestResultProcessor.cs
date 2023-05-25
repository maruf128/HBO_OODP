static class TestResultProcessor
{
    public static Tuple<double, bool> GetTestResult(double behaald, double totaal)
    {
        bool passed;
        if (behaald == 0)
        {
            // indien het 0 is heeft hij het niet gehaald en return dan een 0.0
            return Tuple.Create(0.0, false);
        }
        double cijfer = (behaald / totaal) * 10;
        if (cijfer >= 5.5)
        {
            passed = true;
        }
        else
        {
            passed = false;
        }
        return Tuple.Create(cijfer, passed);
    }
    public static void PrintTestResult(Tuple<double, bool> result)
    {
        Console.WriteLine("Grade: " + result.Item1.ToString("0.0"));
        Console.WriteLine(result.Item2 ? "Passed" : "Did not pass");
    }
}