using System;
class DNA
{
    public string Seq { get; set; }

    // gebruik class name voortaan ook voor de constructor!!
    public DNA(string tekst)
    {
        Seq = tekst;
    }
    public DNA Replicate1()
    {
        // hier maak je gewoon een niewe aan
        return new DNA(Seq);
    }

    public DNA Replicate2()
    {
        // hier gebruik je de huidige
        return this;
    }

    public void Mutate(string newSeq)
    {
        // hier vervang je de tekst met newseq
        Seq = newSeq;
    }
}
class Program
{
    static void Main()
    {
        var dnaA = new DNA("ACGT");
        var dnaB = dnaA.Replicate1();
        dnaA.Mutate("TCGT");
        CompareDNA(dnaA, dnaB);

        var dnaC = new DNA("CGTA");
        var dnaD = dnaC.Replicate2();
        dnaC.Mutate("CCGA");
        CompareDNA(dnaC, dnaD);
    }

    static void CompareDNA(DNA dna1, DNA dna2)
    {
        Console.WriteLine($"{dna1.Seq} and {dna2.Seq} are {(dna1.Seq == dna2.Seq ? "" : "not ")}the same sequence");
        Console.WriteLine($"dna1 and dna2 are {(dna1 == dna2 ? "" : "not ")}the same");
    }
}