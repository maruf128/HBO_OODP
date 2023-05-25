
// vraag hier voor de achernaam
Console.WriteLine("Hello. Please enter your last name.:");
// zet nu de gegeven antwoord in een string met de variable achternaam als naam
string Achternaam = Console.ReadLine();

// stel hier de char alvast vast
char ch;
//vraag nu naar de initial
Console.Write("Enter a character: ");
// convert het nu naar de initial, zorg ook gelijk dat het een hoofdletter word
string initial = Console.ReadLine().ToUpper();
ch = Convert.ToChar(initial);

Console.WriteLine("Welcome to the course, " + ch + " " + Achternaam + ". We will watch your career with great interest.");
