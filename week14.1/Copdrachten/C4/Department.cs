public class Department
{
    public string Name { get; set; }
    Queue<Request> _requests { get; }

    public Department(string naam)
    {
        Name = naam;
        _requests = new Queue<Request>();
    }
    public void AddRequest(Request request)
    {
        // voeg het toe aan 
        _requests.Enqueue(request);
    }
    public Request SolveNextRequest()
    {
        // return de functie, zodat je de eerste verwijderd en de opeen volgende terug stuurt
        return _requests.Dequeue();
    }
    public Request GetNextRequest()
    {
        // returnt de volgende request
        return _requests.Peek();
    }
    public void PrintAllRequests()
    {
        foreach (Request request in _requests)
        {
            Console.WriteLine(request);
            Console.WriteLine();
        }
    }
}