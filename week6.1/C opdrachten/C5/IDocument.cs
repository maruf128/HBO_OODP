public interface IDocument : IStorable
{
    string Title { get; set; } // get en set
    string Content { get; set; } // get en set

    void Print();
}