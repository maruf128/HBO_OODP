class ToDo
{
    // maak een lege lijst
    public List<Task> TaskList { get; set; }
    public ToDo()
    {
        // hier zet je de opgegeven strings in een variable zodat je ze in de latere functie's kan gebruiken
        TaskList = new List<Task>();
    }
    public void AddTask(string name)
    {
        // boeg hier een nieuwe task toe op basis van naam in de lijst
        TaskList.Add(new Task(name));
    }

    public Task GetTask(string name)
    {
        foreach (Task task in TaskList)
        {
            // zeg elke nmaam
            if (task.Name == name)
            {
                // indien de naam gelijk is aan name return die task
                return task;
            }
        }
        // anders return je null
        return null;
    }

    public string Report()
    {
        // maak de print aan
        string report = "";
        foreach (Task task in TaskList)
        {
            // voor iedere taak in de lijst print je wat de naam is en de info ervan (of het done is of pending)
            report += task.Info() + "\n";
            //Task: T1, Status: Pending

        }
        return report;
    }
}