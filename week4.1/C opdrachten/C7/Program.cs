using System;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // lees eerst alles uit de person.json
            string fileName = "People.json";
            StreamReader reader = new(fileName);
            string File2Json = reader.ReadToEnd();
            List<Person> listOfObjects = JsonConvert.DeserializeObject<List<Person>>(File2Json)!;
            reader.Close();
            foreach (Person x in listOfObjects)
            {
                string Persoon_naam = x.Name;
                var autos = x.OwnedCars;
                foreach (Car auto in autos)
                {
                    string naam_auto = auto.Brand;
                    // Console.WriteLine($"{Persoon_naam} heeft deze auto: {naam_auto}");
                    int i = 0;
                    while (i < 5)
                    {
                        auto.Drive();
                        i++;
                    }
                }
            }
            StreamWriter writer = new(fileName);
            string List2Json = JsonConvert.SerializeObject(listOfObjects);
            writer.Write(List2Json);
            writer.Close();
        }
        catch (FileNotFoundException error)
        {
            // eerst kijk je dus of er wel een file is
            Console.WriteLine($"Missing JSON file. {error.Message}");
        }
        catch (JsonReaderException error)
        {
            // dan kijk je of de file wel klopt
            Console.WriteLine($"Invalid JSON. {error.Message}");
        }
    }
}