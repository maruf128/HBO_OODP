// zoek de file
string FileNaam = (@"MyTextFile.txt");
string text = File.ReadAllText(FileNaam);
Console.WriteLine(text);