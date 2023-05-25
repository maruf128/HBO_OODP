class DNA
{
    private static Random _rand = new Random(0); //Seeded Random

    //Fields, constructor and Replicate here

    public DNA Ancestor;
    public string Seq;


    public DNA(DNA ancestor, string seq)
    {
        Ancestor = ancestor;
        // vergeteen niet to upper want je vult kleine letters in
        Seq = seq.ToUpper();
    }
    public DNA Replicate()
    {
        return new DNA(this, MutateTransition(Seq));
    }
    private string MutateTransition(string seq)
    {
        var indexToMutate = _rand.Next(0, Seq.Length);
        var mutatedSeq = Seq[0..indexToMutate] //Left of mutation
            + MutateTransitionTable(Seq[indexToMutate]) //Mutation
            + Seq[(indexToMutate + 1)..Seq.Length]; //Right of mutation
        return mutatedSeq;
    }

    private char MutateTransitionTable(char nucleotide) => nucleotide switch
    {
        'A' => 'G',
        'G' => 'A',
        'C' => 'T',
        'T' => 'C',
        _ => throw new ArgumentOutOfRangeException($"Unexpected nucleotide value: {nucleotide}"),
    };
}
class Program
{
    public static void Main()
    {
        DNA ancestor = new DNA(null, "acgt");
        var dnaLine = new List<DNA>() { ancestor };
        for (int i = 0; i < 25; i++)
        {
            ancestor = ancestor.Replicate();
            dnaLine.Add(ancestor);
        }

        while (ancestor.Ancestor != null)
        {
            Console.WriteLine(ancestor.Ancestor.Seq);
            ancestor = ancestor.Ancestor;
        }
    }
}