public class ImageDocument : Document
{
    public ImageDocument(string title, string fileName) : base(title)
    {
        FileName = fileName;
    }
    public string FileName { get; }

    public new string Title { get; set; }
    public string FilePath { get; set; }

    public override void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}