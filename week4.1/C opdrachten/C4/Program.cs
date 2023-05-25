using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        string fileName = "Cars.json";
        StreamReader reader = new(fileName);
        string File2Json = reader.ReadToEnd();
        List<Car> listOfObjects = JsonConvert.DeserializeObject<List<Car>>(File2Json)!;
        reader.Close();
        foreach (Car x in listOfObjects)
        {
            int i = 0;
            string auto_merk = x.Brand;
            int auto_mile = x.Mileage;
            //maak nieuwe carr
            Car Auto = new Car(auto_merk);
            while (i < 5)
            {
                x.Drive();
                i++;
            }
        }
        StreamWriter writer = new(fileName);
        string List2Json = JsonConvert.SerializeObject(listOfObjects);
        writer.Write(List2Json);
        writer.Close();


    }
}