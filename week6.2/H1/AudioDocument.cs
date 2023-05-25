public class AudioDocument : Document
{
    public int tijd;
    public AudioDocument(string title, int seconden) : base(title)
    {
        tijd = seconden;
    }

    public string FileName { get; }

    public override void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}