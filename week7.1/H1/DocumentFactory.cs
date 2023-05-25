public class DocumentFactory : IFactory<Document>
{
    public Document CreateDarkTheme()
    {
        return new Document("Black", "White");
    }

    public Document CreateLightTheme()
    {
        return new Document("White", "Black");
    }
}