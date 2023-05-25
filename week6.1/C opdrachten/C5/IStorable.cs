public interface IStorable
{
    string FileName { get; set; } // get en set

    void Load();
    void Save();
}