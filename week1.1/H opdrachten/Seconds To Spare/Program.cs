// vraag eerst hoeveel seconden er zijn
Console.WriteLine("How many seconds? ");

// zet nu de age in een varr:
int seconden;
string begin = Console.ReadLine();
// indien de getal te groot word kan je de toint(number) groter maken
seconden = Convert.ToInt32(begin);

// bereken nu hoeveel uren die seconden zijn delen door 3600 
int uren = seconden / 3600;
Console.WriteLine("Hours: " + uren);

// bereken hoeveel seconden je overhebt na aantal uren eraf te halen
int uren_later = uren * 3600;
seconden = seconden - uren_later;

// bereken aantal minuten
int minuten = seconden / 60;
Console.WriteLine("Minutes: " + minuten);

// bereken hoeveel seconden je hebt na ook de minuten eraf te halen en print het gelijk
int minuten_later = minuten * 60;
seconden = seconden - minuten_later;
Console.WriteLine("Seconds left: " + seconden);

