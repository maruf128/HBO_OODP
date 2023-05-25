public class Program
{
    public static void Main(string[] args)
    {
        string[] inputStrArr = args[1..^0];
        //Input strings for first test:
        //"racecar", "hello", "level", "A man, a plan, a canal, Panama!";

        foreach (string str in inputStrArr)
        {
            //Make lowercase and remove non-letters
            string cleanedStr = new string(str.ToLower().Where(c => char.IsLetter(c)).ToArray());

            bool isPalindrome = IsPalindrome(cleanedStr);
            Console.WriteLine($"\"{cleanedStr}\" is {(isPalindrome ? "a palindrome" : "not a palindrome")}");
        }
    }


    //Method Palindrome goes here
    public static bool IsPalindrome(string text)
    {
        if (text.Length <= 1)
        {
            return true; // als het 1 letter is, is het zo wie zo gelijk
        }
        if (text[0] != text[text.Length - 1]) // indien eerste letter en laatste letter niet gelijk zijn kan die niet gelijk zijn
        {
            return false;
        }
        else
        {
            return IsPalindrome(text.Substring(1, text.Length - 2)); // zorg dat je begint bij de 2de letter en eidingt bij een na laatste en gaat zo door
        }
    }
}