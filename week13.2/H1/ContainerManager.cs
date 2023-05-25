using Newtonsoft.Json;

public static class ContainerManager
{
    public static void Start(string folderPath)
    {
        string[] manifestFiles = Directory.EnumerateFiles(folderPath, "*.json").ToArray();

        foreach (string manifestFile in manifestFiles)
        {
            List<Container> containers = ProcessManifest(manifestFile);

            foreach (Container container in containers)
            {
                Console.WriteLine(container.ToString());
            }
        }
    }

    public static List<Container> ProcessManifest(string filePath)
    {
        string json = File.ReadAllText(filePath);
        List<Container> containers = JsonConvert.DeserializeObject<List<Container>>(json);
        return containers;
    }

    public static List<Container> SearchByOrigin(List<Container> containers, string origin)
    {
        List<Container> matchingContainers = containers.FindAll(c => c.Origin == origin);
        return matchingContainers;
    }

    public static Container SearchForHeaviest(List<Container> containers)
    {
        Container heaviestContainer = containers.MaxBy(c => c.Weight);
        return heaviestContainer;
    }
}
