string FileNaam = (@"MyTextFile.txt");
// de tekst van codegrade
string added_text = "" + Environment.NewLine;
// append nu de tekst
File.AppendAllText(FileNaam, added_text);

// eigen tekst
string eigen_tekst = "added line." + Environment.NewLine;
// append nu de tekst
File.AppendAllText(FileNaam, eigen_tekst);

// lees de file nu uit
string readText = File.ReadAllText(FileNaam);
Console.WriteLine(readText);