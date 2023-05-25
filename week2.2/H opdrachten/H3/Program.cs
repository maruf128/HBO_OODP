
class Program
{
    class DNA
    {
        public string Seq { get; set; }
        public DNA(string seq)
        {
            // hier zet je de opgegeven strings in een variable zodat je ze in de latere functie's kan gebruiken
            Seq = seq;
        }
    }
    static void Main(string[] args)
    {
        // maak de list aan
        List<DNA> dnaList = new List<DNA>()
        {
            new DNA("ACGT"),
            new DNA("GCTTAC"),
            new DNA("CGTTAGCTT"),
            new DNA("TACA")
        };

        // vraag voor de lengte
        Console.WriteLine("What is the minimum sequence length?");
        int minLength = int.Parse(Console.ReadLine());

        // filterde list waar het gelijk is aan de lengte of groter op basis van de oude lijst
        List<DNA> filteredList = dnaList.Where(dna => dna.Seq.Length >= minLength).ToList();

        // print nu de gefilterde lijst
        Console.WriteLine("The filtered list:");
        foreach (DNA dna in filteredList)
        {
            Console.WriteLine(dna.Seq);
        }
    }
}
