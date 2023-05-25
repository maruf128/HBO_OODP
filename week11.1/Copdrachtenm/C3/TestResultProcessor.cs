static class TestResultProcessor
{
    public static (double grade, bool passed) GetTestResult(double behaald, double totaal)
    {
        bool passed;
        if (behaald == 0)
        {
            // indien het 0 is heeft hij het niet gehaald en return dan een 0.0
            return (0.0, false);
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
        return (cijfer, passed);
    }
    public static void PrintTestResult((double grade, bool passed) resutl)
    {
        Console.WriteLine("Grade: " + resutl.grade.ToString("0.0"));
        Console.WriteLine(resutl.passed ? "Passed" : "Did not pass");
    }
}
