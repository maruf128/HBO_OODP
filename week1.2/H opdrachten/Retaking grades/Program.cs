// maak eerst de lijs:
List<double> grades = new List<double>();
List<double> uodated_grades = new List<double>();

// voeg nu alle cijfers toe
grades.Add(6.5);
grades.Add(9.5);
grades.Add(4);
grades.Add(5);
grades.Add(4.5);
grades.Add(10);
grades.Add(7.1);

// maak de nieuwe value aan zodat je de x erin kan zetten
double nieuwe_value;
foreach (double x in grades)
{
    // indien het hoger dan een 5.5 is doe dit
    if (x >= 5.5)
    {
        // voeg het dan aan de geupdate grade lijst
        nieuwe_value = x;
        uodated_grades.Add(x);
    }
    else
    {
        // maak de inputs alvast aan
        string input = "";
        string antwoord = "";
        // in het begin en als het antwoord niet klopt vraag het opnieuw
        while (antwoord != "y" && antwoord != "n")
        {
            // vraag of de user het wilt herkansen
            Console.Write("Retake this course? y/n");
            // zet het in een variable en maak het gelijk een kleinere letter
            input = Console.ReadLine();
            antwoord = input.ToLower();
        }
        // nu heb je het antwoord
        // indien het uiteindelijk een y of n is ga dan naar de if statements

        if (antwoord == "y")
        {
            // aka de gebruiker wilt herkansen dus krijgt hij/zij een +1
            nieuwe_value = x + 1;
            uodated_grades.Add(nieuwe_value);
        }
        // aka de gebruiker wilt niet herkansen voeg dan de normale cijfer toe
        else if (antwoord == "n")
        {
            nieuwe_value = x;
            uodated_grades.Add(x);
        }
    }
    //Console.WriteLine(x);
}

// schirjf nu met een for each loop elke nieuwe cijfer uit de geupdate versie
// extra regel om in codegrade goed te lezen
Console.WriteLine();
foreach (double y in uodated_grades)
{
    Console.WriteLine(y);
}