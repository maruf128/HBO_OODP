public class DocumentCollection
{
    private List<Document> _documents = new List<Document>();

    public void AddDocument(Document document)
    {
        _documents.Add(document);
    }
    public void RemoveDocument(Document document)
    {
        _documents.Remove(document);
    }

    public void DisplayDocuments()
    {
        foreach (Document document in _documents)
        {
            Console.WriteLine($"{document.ID}: {document.Title}");
        }
    }

    public Document FindDocument(string title)
    {
        foreach (Document document in _documents)
        {
            if (document.Title == title)
            {
                document.Accept(new DocumentVisitor());
                return document;
            }
        }
        return null;
    }
}