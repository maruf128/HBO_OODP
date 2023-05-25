// laat de gebruiker eerst zien wat de keuzes zijn
Console.WriteLine("Enter an age:");
int leeftijd;
string age = Console.ReadLine();
leeftijd = Convert.ToInt16(age);

// passing string "str" in
// switch statement=
string favoriteTask = leeftijd switch
{
    // hier vergelijk ik alle cases
    >= 0 and <= 12 => "Age " + leeftijd + ": a child", // indien de gebruiker 0 of ouder dan 0 is en 12 of jonger dan 12 dan is het een kind
    >= 13 and <= 19 => "Age " + leeftijd + ": a teenager ", // indien de gebruiker 13 of ouder dan 13 is en 19 of jonger dan 19 dan is het een teenager
    >= 20 and <= 150 => "Age " + leeftijd + ": an adult ", // indien de gebruiker 20 of ouder dan 20 is en 150 of jonger dan 150 dan is het een adult
    _ => "Age " + leeftijd + ": invalid " //
};
// hier print je de text uit op basis van welke case van toepassing is
Console.WriteLine(favoriteTask);
