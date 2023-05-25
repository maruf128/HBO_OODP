public interface IDocumentVisitor
{
    void Visit(TextDocument textDoc);
    void Visit(ImageDocument ImageDoc);
    void Visit(AudioDocument audioDoc);

}