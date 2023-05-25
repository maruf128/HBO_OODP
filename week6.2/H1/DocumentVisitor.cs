
public class DocumentVisitor : IDocumentVisitor
{
    public void Visit(TextDocument textDoc)
    {
        Console.WriteLine($"Text document: {textDoc.Title}");
        // krijg de body
        string filenaam = textDoc.Title;
        string Body = textDoc.Body;
        Console.WriteLine($"body: {Body}");
    }

    public void Visit(ImageDocument ImageDoc)
    {
        Console.WriteLine($"Image document: {ImageDoc.FileName}");
        // krijg volledige path
        Console.WriteLine($"File path: {ImageDoc.FilePath}");
        //Image document: Family picture

        //File path: C:/ Users / JohnDoe / family.jpg
    }

    public void Visit(AudioDocument audioDoc)
    {
        Console.WriteLine($"Audio document: {audioDoc.Title}");
        Console.WriteLine($"Audio document: {audioDoc.tijd}");

    }
}