public class contacten
{
    Dictionary<string, string> contacts;

    public contacten()
    {
        contacts = new Dictionary<string, string>();
    }
    public void Add(string name, string nummer)
    {
        contacts.Add(name, nummer);
    }
    public string View(string name)
    {
        foreach (KeyValuePair<string, string> contact in contacts)
        {
            if (contact.Key == name)
            {
                // nummer gevonden
                return $"Phone number: {contact.Value}.";
            }
        }
        return $"Contact not found.";
    }
    public void Remove(string name)
    {
        foreach (KeyValuePair<string, string> contact in contacts)
        {
            if (contact.Key == name)
            {
                // nummer gevonden
                contacts.Remove(contact.Key);
                break;
            }
        }
    }
    public void List()
    {
        foreach (KeyValuePair<string, string> contact in contacts)
        {
            Console.WriteLine($"{contact.Key}: {contact.Value}");
        }
    }
}