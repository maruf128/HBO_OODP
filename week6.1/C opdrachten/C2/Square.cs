public class Square : IDrawable, IResizable
{
    public int Size { get; private set; }
    public Square(int size) => Size = size;

    // roep nu de rezise funtie van de interface
    public void Resize(double getal)
    {
        Size = Convert.ToInt32(Math.Floor(Size * getal));
    }

    public void Draw()
    {
        string breedte = "";
        for (int i = 0; i < Size; i++) // zolang i kleiner is dan de size
        {
            breedte += "*";
        }
        // nu je de breedte hebt maak de hoogte
        for (int i = 0; i < Size; i++)
        {
            Console.WriteLine(breedte);
        }
        Console.WriteLine();// kijken of codegrade dit goed keurt
    }
}