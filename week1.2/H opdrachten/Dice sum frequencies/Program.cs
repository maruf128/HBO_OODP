Random rand = new(0);
var howManyTimes = 500;
var dieSides = 6;

List<List<int>> results = new();
for (int i = 0; i < howManyTimes; i++)
{
    List<int> rollResults = new();
    for (int j = 0; j < 2; j++)
    {
        rollResults.Add(rand.Next(1, dieSides + 1));
    }
    results.Add(rollResults);
}

List<string> freqs = new()
{
    " 2: ",
    " 3: ",
    " 4: ",
    " 5: ",
    " 6: ",
    " 7: ",
    " 8: ",
    " 9: ",
    "10: ",
    "11: ",
    "12: ",
};

/*
 * Your code goes here.
 * List 'results' is a nested List. Each inner List contain two numbers.
 * For each inner List, you need to sum the two numbers, then update 'freqs'.
 * For example, if the sum of the two dice is 7, add a pipe to the string "7: ".
 */
// for iedere nummer die je gerold hebt
for (int i = 0; i < howManyTimes; i++)
{
    // print dan een streepje
    int sum = results[i][0] + results[i][1];
    int index = sum - 2;
    // voeg het dan toen aan fregs
    freqs[index] += "|";
}

foreach (var freq in freqs)
{
    // en hier schrijf je het
    Console.WriteLine(freq);
}
