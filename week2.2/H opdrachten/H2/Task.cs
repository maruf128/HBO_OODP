class Task
{
    public string Name { get; set; }
    public bool IsDone { get; set; }
    public Task(string naam)
    {
        // hier zet je de opgegeven strings in een variable zodat je ze in de latere functie's kan gebruiken
        Name = naam;
        IsDone = false;
    }
    public void Done()
    {
        // hier zet je isdone op true
        IsDone = true;
    }
    public string Info()
    {
        if (IsDone)
        {
            // aka hij is true
            return "Done";
        }
        else
        {
            // anders moet ie wel false zijn
            return $"Task: {Name}, Status: Pending";
        }
    }
}