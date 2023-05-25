// vraag eerst naar de maand\
int maand;
Console.WriteLine("What is the month? 1-12");
string vraag_maand = Console.ReadLine();
// maak er een int van
maand = Convert.ToInt32(vraag_maand);

// vraag nu naar de dag
int dag;
Console.WriteLine("What is the day? 1-31");
string vraag_dag = Console.ReadLine();
// maak er een int van
dag = Convert.ToInt32(vraag_dag);

// test om te kijken of je kan bereken
DateTime aDate = new DateTime(2023, maand, dag);
// nu heb je de datum van de gegeven user
var datum = aDate.ToString("dd-MM");
var Pdatum = aDate.ToString("dd-M");
Console.WriteLine(aDate);

// winter met if statements voro het geval je naar het volgende jaar moet vergelijken
// ik heb een andere soort functie gebruik zodat ik geen if en else statements hoef te gebruiken
DateTime begin_winter_volledig;
DateTime eind_winter_volledig;
begin_winter_volledig = (maand == 12) ? new DateTime(2023, 12, 21) : new DateTime(2022, 12, 21);
eind_winter_volledig = (maand == 12) ? new DateTime(2024, 03, 20) : new DateTime(2023, 03, 20);


Console.WriteLine(begin_winter_volledig);
Console.WriteLine(eind_winter_volledig);

//spring
DateTime begin_spring_volledig = new DateTime(2023, 3, 21);
DateTime eind_spring_volledig = new DateTime(2023, 6, 20);

//summer
DateTime begin_summer_volledig = new DateTime(2023, 6, 21);
DateTime eind_summer_volledig = new DateTime(2023, 9, 20);
// Console.WriteLine(begin_summer_volledig);
// Console.WriteLine(eind_summer_volledig);

//autumn
DateTime begin_autumn_volledig = new DateTime(2023, 9, 21);
DateTime eind_autumn_volledig = new DateTime(2023, 12, 20);

int text = (aDate >= begin_spring_volledig && aDate <= eind_spring_volledig) ? 1 :
       (aDate >= begin_summer_volledig && aDate <= eind_summer_volledig) ? 2 :
       (aDate >= begin_autumn_volledig && aDate <= eind_autumn_volledig) ? 3 :
       (aDate >= begin_winter_volledig && aDate <= eind_winter_volledig) ? 4 :
       0;

//switch
PrintFortune(text, Pdatum);


static void PrintFortune(int text, string Pdatum)
{
    string score = text switch
    {
        1 => $"On {Pdatum} it is Spring",
        2 => $"On {Pdatum} it is Summer",
        3 => $"On {Pdatum} it is Autumn",
        4 => $"On {Pdatum} it is Winter",
        _ => $"error met {Pdatum}"
    };
    Console.WriteLine(score);
}