class Person
{
    // eerst zet je de firstname en lastname op get en set zodat je makkelijker toegang hebt
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        // hier zet je de opgegeven strings in een variable zodat je ze in de latere functie's kan gebruiken
        FirstName = firstName;
        LastName = lastName;
    }

    public string Introduce() => $"I am {FirstName} {LastName}";
}

// hier komt normaal de program en main
// zodat je een persoon kan aanmaken en uitlezen, maar volgens codegrade mag dat niet en doen zij het zelf

