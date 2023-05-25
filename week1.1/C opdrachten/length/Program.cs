// print eerst dat de persoon een 6 letterig woord moet raden
Console.WriteLine("You have one chance to guess this six-letter word:");
Console.WriteLine("Le..th");
string woord = Console.ReadLine();
if (woord == "Length")
{
    Console.WriteLine("Correct!");
}
else if (woord == "length")
{
    Console.WriteLine("Kind of correct; the case was just wrong (hint: use ToLower())");
}
else if (woord.Length != 6)
{
    Console.WriteLine("Incorrect! That is not even a six-letter word!");
}
else
{
    Console.WriteLine("Incorrect!");
}