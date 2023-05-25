// vraag1
Console.WriteLine("Answer the following MCQs:");
int totale_score = 0;
Console.WriteLine("Which of the following is NOT a valid type in C#?");
Console.WriteLine("A: bool");
Console.WriteLine("B: int");
Console.WriteLine("C: var"); // juiste antwoord
Console.WriteLine("D: string");
string vraag1 = Console.ReadLine();
vraag1 = vraag1.ToLower();
// aka het is uberhaupt een van de gegeven antworden
if (vraag1 == "c")
{
    //aka de antwoord was juist
    totale_score = totale_score + 1;
    // zet ook de while loop op true en vraag veder
} // indien anders dan is hij gwn fout


//vraag 2
Console.WriteLine("What happens if you execute the following line C#?");
Console.WriteLine("int x = 1.23;");
Console.WriteLine("A: x will be 1.23");
Console.WriteLine("B: x will be 1");
Console.WriteLine("C: x will be 1.0");
Console.WriteLine("D: you will get a compiler error");// juiste antwoord
string vraag2 = Console.ReadLine();
vraag2 = vraag2.ToLower();
// aka het is uberhaupt een van de gegeven antworden
if (vraag2 == "d")
{
    //aka de antwoord was juist
    totale_score = totale_score + 1;
    // zet ook de while loop op true en vraag veder
}// als het fout blijft add je niks meer zo veder

// vraag 3 (hier kunnen 2 vragen goed zijn)
Console.WriteLine("Consider the following line:");
Console.WriteLine("double d = 1.23;");
Console.WriteLine("What are TWO ways to convert variable d to an int?");
Console.WriteLine("A: int i = (int)d;");// een juiste antwoord
Console.WriteLine("B: int i = int(d)");
Console.WriteLine("C: int i = 0 + d");
Console.WriteLine("D: int i = Convert.ToInt32(d)");// een juiste antwoord
string vraag3_eerstehelft = Console.ReadLine();
vraag3_eerstehelft = vraag3_eerstehelft.ToLower();
// teweede antwoord
Console.WriteLine("Consider the following line:");
Console.WriteLine("double d = 1.23;");
Console.WriteLine("What are TWO ways to convert variable d to an int?");
Console.WriteLine("A: int i = (int)d");// een juiste antwoord
Console.WriteLine("B: int i = int(d)");
Console.WriteLine("C: int i = 0 + d");
Console.WriteLine("D: int i = Convert.ToInt32(d)");// een juiste antwoord
string vraag3_tweedehelft = Console.ReadLine();
vraag3_tweedehelft = vraag3_tweedehelft.ToLower();
// kijk eerst of eerst antwoord juist is in bijde manieren
// ad of da
if (vraag3_eerstehelft == "a" && vraag3_tweedehelft == "d" || vraag3_eerstehelft == "d" && vraag3_tweedehelft == "a")
{
    // dan zet je goede antwoord
    totale_score = totale_score + 1;
}
// print eerst alle antwoorden uit:
Console.WriteLine("Your first answer:");
Console.WriteLine(vraag1);
Console.WriteLine("Your second answer:");
Console.WriteLine(vraag2);
Console.WriteLine("Your last 2 answers for question3 where:");
Console.WriteLine(vraag3_eerstehelft + vraag3_tweedehelft);
PrintFortune(totale_score);

static void PrintFortune(int totale_score)
{
    string score = totale_score switch
    {
        1 => $"Your score: {totale_score} out of 3.",
        2 => $"Your score: {totale_score} out of 3.",
        3 => $"Your score: {totale_score} out of 3. Well done!", // aka alle antwoorden goed
        4 => "You will be loved, and you'll be happy, rich and famous!",
        0 => $"Your score: {totale_score} out of 3."
    };
    Console.WriteLine(score);
}