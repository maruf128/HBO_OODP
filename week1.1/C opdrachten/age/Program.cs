// vraag om de age van de persoon:
Console.WriteLine("What is your age? ");

// zet nu de age in een varr:
int leeftijd;
string age = Console.ReadLine();
leeftijd = Convert.ToInt16(age);
// print nu de age die de persoon nu heeft:
Console.WriteLine("You are " + leeftijd + ". That's old enough to program!");

// zorg nu dat je de leeftijd van vorig jaar berekent aka -1
int vorig_jaar = leeftijd - 1;
Console.WriteLine("Last year you were " + vorig_jaar);

// zorgt nu dat je de leeftijd van volgens jaar berekent aka +1
int volgend_jaar = leeftijd + 1;
Console.WriteLine("Next year you will be " + volgend_jaar);

// zorg nu dat je het dubbele van je leeftijd weet aka *2
int dubbele = leeftijd * 2;
Console.WriteLine("At double your age you will be " + dubbele);

// zorg nu dat je het dubbele van je leeftijd weet volgend jaar aka +1 en dan *2
int volgend_dubbel = volgend_jaar * 2;
Console.WriteLine("Next year, double your age will be " + volgend_dubbel);

// zorg nu dat je de helft van je leeftijd weet aka /2
double helft = leeftijd / 2.0;
// double zorgt ervoor dat je met decimalen kan showen
Console.WriteLine("Half your age is " + helft);

// zorg nu dat je de helft heb maar afgerond
int afgerond_helft = leeftijd / 2;
Console.WriteLine("Half your age (rounded down) is " + afgerond_helft);

// zorg dat je de laatste cijfer van de leeftijd krijgt, dat doe je blijkbaar door % 10
int procent_age = leeftijd % 10;
Console.WriteLine("The last digit of your age is " + procent_age);
