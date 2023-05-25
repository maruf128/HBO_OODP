public class TextDocument : Document
{
    public string Body;
    public TextDocument(string title, string body) : base(title)
    {
        Body = body;
    }

    public override void Accept(IDocumentVisitor visitor)
    {
        // krijg eerst de text
        if (Body.Split('\n').Length <= 10)
        {
            Console.WriteLine($"Processing short document...");
        }
        else if (Body.Split('\n').Length > 10)
        {
            Console.WriteLine($"Processing long document...");
        }

        visitor.Visit(this);
    }
}