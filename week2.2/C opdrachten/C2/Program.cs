class Artist
{
    public string Name;
    public int NumberOfSongs;

    public Artist(string name) => Name = name;

    public Song WriteSong(string name)
    {
        NumberOfSongs++;
        var song = new Song(name);
        song.SetSinger(this);
        return song;
    }
}
class Song
{
    // stel de 2 variables vast
    public string titel { get; set; }
    public Artist zanger { get; set; }

    // geef het een constructor
    public Song(string title)
    {
        titel = title;
        // zager moet unkown hjebben
        zanger = new Artist("Unknown");
    }

    public void SetSinger(Artist singer)
    {
        // hier stel je de zanger vast via de artist class
        zanger = singer;
    }

    public string Info()
    {
        // hier schrijf je de info
        return $"{titel} is by {zanger.Name}";
    }
}

class Program
{
    public static void Main()
    {
        Artist artist = new Artist("Rihanna");

        Song song = artist.WriteSong("Umbrella");
        Console.WriteLine(song.Info());

        artist.Name = "Robyn Rihanna Fenty";
        Console.WriteLine(song.Info());
    }
}