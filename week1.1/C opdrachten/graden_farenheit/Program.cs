// vraag eerst hoeveel graden het is
Console.WriteLine("What is the temperature in Celsius? ");
// zet nu de graden in een variable om het later te gebruiken
int graden;
string celcius = Console.ReadLine();
graden = Convert.ToInt16(celcius);
// Console.WriteLine(graden); (hiermee kan je de graden printen)

// bereken nu hoeveel graden farenheit is, *1,8 en plus 32
double farenheit = graden * 1.8 + 32;
// print nu zoals aangegeven
Console.WriteLine(graden + " C = " + farenheit + " F");

// maak het nu afgerond en print het
double afgerond = Math.Floor(farenheit);
// het hoort round te zijn maar codegrade wilt het naar beneden afronden, dan gebruik je "floor"
Console.WriteLine("Rounded down that is " + afgerond + " F");