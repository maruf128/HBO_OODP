
using System;

class Program
{
    public static void Main()
    {
        bool english = true;
        bool math = true;
        bool retake = true;
        bool semester = true;

        if (english == true)
        {
            Console.WriteLine($"Did you pass English? {english}");
        }
        if (math == true)
        {
            Console.WriteLine($"Did you pass Math? {math}");
        }
        if (retake == true)
        {
            Console.WriteLine($"Did you need to do any retakes? {retake}");
        }
        if (semester == true)
        {
            Console.WriteLine($"Did you pass this semester? {semester}");
        }
    }
}