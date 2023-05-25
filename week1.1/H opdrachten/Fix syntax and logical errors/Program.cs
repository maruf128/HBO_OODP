double discount = 10;
int price = 55;
double discountPrice = price - (price * discount / 100);
discountPrice = Math.Round(discountPrice, 2, MidpointRounding.AwayFromZero); // met away from zero rond hij geld op de juiste manier af
var message = $"The discount price is {discountPrice}";
Console.WriteLine(message);
// fout 1: op regel 7 moest ik hier ; plaatsten om het goed te sluiten
// fout 2: regel 1 geef je aan dat het een int is en dan geef je een double getal
// fout 3: op regel 3 geef je aan dat je een int wilt maar je berekent met een double dus dat moet ook een double worden
// fout 4: op regel 5 geef je aan dat het een var moet zijn maar dat kan je niet doen met een lege variable
// fout 5: de manier hoe je de discount berekent klopt niet
// fout 6: je write alleen de discount niet de messagde
// fout 7: deze fout kan door mij komen maar sinds je niet afround op 2 is dat ook fout sinds het geld is
// fout 8: de discount hoort niet 0.1 te zijn maar 10 (moet wel dubble blijven anders klopt het niet)