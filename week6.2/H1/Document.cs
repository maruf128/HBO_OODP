public abstract class Document
{
    public static int DocumentID = 0; // begint op 0
    public string Title;
    public int ID; // unieke id


    public Document(string titel)
    {
        Title = titel;
        DocumentID++; // blijft verhogen
        ID = DocumentID; // zet het in de nieuwe
    }

    public abstract void Accept(IDocumentVisitor visitor);
}